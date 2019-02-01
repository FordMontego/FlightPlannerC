using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Flight planner in C#
/// By D.Parsons
/// On 1 December 2018
/// This calculates the amount of fuel needed and checks that the aircraft is within maximum
/// take off weight based on type distances, fuel, passengers and cargo
/// </summary>
namespace FlightPlannerC
{
    public partial class Form1 : Form
    {
        #region hide
        bool bLoaded = false; // to prevent start up causing validation failures
        Int32 iWindX,
            iWindY,
            iInter,
            iHeadX,
            iHeadY,
            iTrackX,
            iTrackY;
        string sConnectChar = "";

        public Form1()
        {
            InitializeComponent();
            Form1_Load();
        }

        private void Form1_Load()
        {
            bLoaded = false;
            cbxPlane.SelectedItem = "Cessna C172SP Skyhawk";
            nudHeadDir.Visible = true;
            nudHeadSpd.Visible = true;
            nudTrackDir.Visible = false;
            nudTrackSpd.Visible = false;
            txtTrackDir.Visible = true;
            txtTrackSpd.Visible = true;
            txtHeadDir.Visible = false;
            txtHeadSpd.Visible = false;
            rbuTrack.Checked = true;
            nudHeadSpd.Value = nudCruiseSpeed.Value;
            FuelSub1();
            bLoaded = true;
            sCalcDescDist();
        }

        private void FuelSub1()
        {
            txtTimeAloft.Text = Math.Round(nudMaxRange.Value / nudCruiseSpeed.Value, 2).ToString();
            txtFlowRate.Text = Math.Round(nudMaxFuel.Value / Convert.ToDecimal(txtTimeAloft.Text), 2).ToString();
            txtFuelNeeded.Text = Math.Round((((nudPlannedDistance.Value + nudDistanceToAlternative.Value) / nudCruiseSpeed.Value) + (nudReserve.Value / 60)) * Convert.ToDecimal(txtFlowRate.Text), 0).ToString();
            WeightSub1();
        }

        private void sCalcDescDist()
        {
            if (bLoaded)
            {
                epDescentRange.Clear();
                decimal iDrop,
                    iTimeToDesc,
                    iAveSpd,
                    iDtoDesc;

                iDrop = nudCruiseAlt.Value - nudAirportAlt.Value;       // in feet
                iTimeToDesc = iDrop / nudRoD.Value;                     // in minutes
                iAveSpd = (nudLandSpd.Value + nudCruiseSpeed.Value) / 2;    // in Nm per hour
                iDtoDesc = Math.Round(iTimeToDesc * iAveSpd / 60, 2);
                txtDtoDesc.Text = iDtoDesc.ToString();
                if (iDtoDesc > nudPlannedDistance.Value)
                {
                    this.epDescentRange.SetError(txtDtoDesc, "Check Altitude/Rate of Desc: Distance greater than planned journey");
                }
                else if (iDtoDesc > (nudPlannedDistance.Value / 2))
                {
                    this.epDescentRange.SetError(txtDtoDesc, "Check Altitude/Rate of Desc: Distance greater than half planned journey");
                }
                else
                {
                    this.epDescentRange.Clear();
                }
            }
        }
        #endregion hide 
        private void cbxPlane_SelectedIndexChanged(object sender, EventArgs e)
        {
            Plane Aircraft = new Plane(cbxPlane.SelectedItem.ToString());
            nudCruiseSpeed.Value = Aircraft.CruiseSpeed;
            nudMaxRange.Value = Aircraft.MaxRange;
            nudMaxFuel.Value = Aircraft.MaxFuel;
            nudEmptyWeight.Value = Aircraft.EmptyWeight;
            nudAircraftMaxTO.Value = Aircraft.MaxTakeOff;
            nudCruiseAlt.Value = Aircraft.CruisingAlt;

            nudHeadSpd.Value = nudCruiseSpeed.Value;
            FuelSub1();
        }

        #region  hide
        private void Vectors_Changed(object sender, EventArgs e)
        {
            if (bLoaded)
            {
                if (nudHeadDir.Value < 1)
                {
                    nudHeadDir.Value = 360;
                }
                else if (nudHeadDir.Value > 360)
                {
                    nudHeadDir.Value = nudHeadDir.Value - 360;
                }
                if (nudWindDir.Value < 1)
                {
                    nudWindDir.Value = 360;
                }
                else if (nudWindDir.Value > 360)
                {
                    nudWindDir.Value = nudWindDir.Value - 360;
                }
                if (nudTrackDir.Value < 1)
                {
                    nudTrackDir.Value = 360;
                }
                else if (nudTrackDir.Value > 360)
                {
                    nudTrackDir.Value = nudTrackDir.Value - 360;
                }
                iWindX = Convert.ToInt16((double)nudWindSpd.Value * Math.Cos((double)nudWindDir.Value * Math.PI / 180));
                iWindY = Convert.ToInt16((double)nudWindSpd.Value * Math.Sin((double)nudWindDir.Value * Math.PI / 180));

                if (this.rbuTrack.Checked)
                {
                    this.iHeadX = Convert.ToInt16((double)nudHeadSpd.Value * Math.Cos((double)nudHeadDir.Value * Math.PI / 180));
                    this.iHeadY = Convert.ToInt16((double)nudHeadSpd.Value * Math.Sin((double)nudHeadDir.Value * Math.PI / 180));
                    this.iInter = Convert.ToInt16((double)Math.Round(Math.Atan2(-iWindY + iHeadY, -iWindX + iHeadX) * 180 / Math.PI, 0));
                    if (this.iInter < 1)
                    {
                        txtTrackDir.Text = (Convert.ToDecimal(this.iInter.ToString()) + 360).ToString();
                    }
                    else
                    {
                        txtTrackDir.Text = this.iInter.ToString();
                    }

                    this.txtTrackSpd.Text = Math.Round(Math.Sqrt(Math.Pow((-iWindX + iHeadX), 2) + Math.Pow((-iWindY + iHeadY), 2)), 0).ToString();
                    if (Convert.ToInt16(txtTrackSpd.Text) < 1)
                    {
                        txtTrackSpd.Text = "1";
                    }
                    nudTrackDir.Value = Convert.ToInt16(txtTrackDir.Text);
                    nudTrackSpd.Value = Convert.ToInt16(txtTrackSpd.Text);
                    txtHeadDir.Text = nudHeadDir.Value.ToString();
                    this.txtHeadSpd.Text = nudHeadSpd.Value.ToString();
                }
                else
                {
                    iTrackX = Convert.ToInt16((double)nudTrackSpd.Value * Math.Cos((double)nudTrackDir.Value * Math.PI / 180));
                    iTrackY = Convert.ToInt16((double)nudTrackSpd.Value * Math.Sin((double)nudTrackDir.Value * Math.PI / 180));
                    iInter = Convert.ToInt16(Math.Round(Math.Atan2(iTrackY + iWindY, iTrackX + iWindX) * 180 / Math.PI, 0));
                    if (iInter < 1)
                    {
                        txtHeadDir.Text = (iInter + 360).ToString();
                    }
                    else
                    {
                        txtHeadDir.Text = iInter.ToString();
                    }
                    txtHeadSpd.Text = Math.Round(Math.Sqrt(Math.Pow((iTrackX + iWindX), 2) + Math.Pow((iTrackY + iWindY), 2)), 0).ToString();
                    if (Convert.ToInt16(txtHeadSpd.Text) < 1)
                    {
                        txtHeadSpd.Text = "1";
                    }
                    nudHeadDir.Value = Convert.ToInt16(txtHeadDir.Text);
                    nudHeadSpd.Value = Convert.ToInt16(txtHeadSpd.Text);
                    txtTrackDir.Text = nudTrackDir.Value.ToString();
                    txtTrackSpd.Text = nudTrackSpd.Value.ToString();
                }
            }
        }

        private void RangeChanged(object sender, EventArgs e)
        {
            if (bLoaded)
            {
                FuelSub1();
                sCalcDescDist();
            }
        }

        private void Weight_Changed(object sender, EventArgs e)
        {
            if (bLoaded)
            {
                WeightSub1();
            }
        }

        private void rbuHead_CheckedChanged(object sender, EventArgs e)
        {
            if (bLoaded)
            {
                nudHeadDir.Visible = false;
                nudHeadSpd.Visible = false;
                nudTrackDir.Visible = true;
                nudTrackSpd.Visible = true;
                txtTrackDir.Visible = false;
                txtTrackSpd.Visible = false;
                txtHeadDir.Visible = true;
                txtHeadSpd.Visible = true;
            }
        }

        private void rbuTrack_CheckedChanged(object sender, EventArgs e)
        {
            if (bLoaded)
            {
                nudHeadDir.Visible = true;
                nudHeadSpd.Visible = true;
                nudTrackDir.Visible = false;
                nudTrackSpd.Visible = false;
                txtTrackDir.Visible = true;
                txtTrackSpd.Visible = true;
                txtHeadDir.Visible = false;
                txtHeadSpd.Visible = false;
            }
        }

        private void Descent_Range(object sender, EventArgs e)
        {
            sCalcDescDist();
        }

        private void WeightSub1()
        {
            txtTOWeight.Text = Math.Round(Convert.ToDecimal(txtFuelNeeded.Text) + nudEmptyWeight.Value + nudCabinWeight.Value + nudCargo.Value, 0).ToString();
            txtSpareWeight.Text = Math.Round(nudAircraftMaxTO.Value - Convert.ToDecimal(txtTOWeight.Text), 0).ToString();
            statusBar1.Text = "";
            sConnectChar = "";
            if (Convert.ToDecimal(txtFuelNeeded.Text) > nudMaxFuel.Value)
            {
                statusBar1.Text = "Over Fuel Capacity (lbs)";
                lblFuelNeeded.ForeColor = Color.Red;
                txtFuelNeeded.BackColor = Color.Red;
                epFuel.SetError(txtFuelNeeded, "Cannot over-fill fuel tank");
                epFuel.SetError(nudPlannedDistance, "Select closer destination to reduce fuel requirement");
                epFuel.SetError(nudDistanceToAlternative, "Select nearer alternative to reduce fuel requirment");
                epFuel.SetError(nudReserve, "Reduce Reserve time to reduce fuel requirement");
                sConnectChar = ": ";
            }
            else
            {
                lblFuelNeeded.ForeColor = Color.Green;
                txtFuelNeeded.BackColor = Color.Gainsboro;
                epFuel.Clear();
            }
            if (Convert.ToDecimal(txtSpareWeight.Text) < 0)
            {
                statusBar1.Text = statusBar1.Text + sConnectChar + "Over T/O Weight (lbs)";
                lblSpareWeight.ForeColor = Color.Red;
                txtSpareWeight.BackColor = Color.Red;
                sConnectChar = ": ";
                epWeight.SetError(txtTOWeight, "Over maximum Take-Off Weight");
                epWeight.SetError(nudCabinWeight, "Reduce number of Passengers to lower cabin weight");
                epWeight.SetError(nudCargo, "Lighten cargo weight");
                epWeight.SetError(txtCalcRange, "Select closer destination or alternative or Reserve to lighten fuel load");
            }
            else
            {
                lblSpareWeight.ForeColor = Color.Black;
                txtSpareWeight.BackColor = Color.Gainsboro;
                epWeight.Clear();
            }
            txtCalcRange.Text = Math.Round(nudPlannedDistance.Value + nudDistanceToAlternative.Value + (nudCruiseSpeed.Value * nudReserve.Value / 60), 2).ToString();
            if (Convert.ToDecimal(txtCalcRange.Text) > nudMaxRange.Value)
            {
                statusBar1.Text = statusBar1.Text + sConnectChar + "Beyond Maximum Range (NM)";
                lblCalcRange.ForeColor = Color.Red;
                txtCalcRange.BackColor = Color.Red;
                epRange.SetError(txtCalcRange, "Total Distance greater than maximum range");
                epRange.SetError(nudPlannedDistance, "Select closer destination to reduce range");
                epRange.SetError(nudDistanceToAlternative, "Select nearer alternative to reduce range");
                epRange.SetError(nudReserve, "Reduce Reserve to reduce range");
                sConnectChar = ": ";
            }
            else
            {
                lblCalcRange.ForeColor = Color.Black;
                txtCalcRange.BackColor = Color.Gainsboro;
                epRange.Clear();
            }
            if (nudDistanceToAlternative.Value == 0)
            {
                nudDistanceToAlternative.ForeColor = Color.Red;
                statusBar1.Text = statusBar1.Text + sConnectChar + "No Alternative Destination Selected";
                epAlternative.SetError(nudDistanceToAlternative, "No alternative destination distance entered");
                sConnectChar = ": ";
            }
            else
            {
                nudDistanceToAlternative.ForeColor = Color.Black;
                epAlternative.Clear();
            }
            txtEstTime.Text = Math.Round(Convert.ToDecimal(txtCalcRange.Text) / nudCruiseSpeed.Value, 2).ToString();
        }
        #endregion hide

        private void btnReview_Click(object sender, EventArgs e)
        {
            txtEstJnyTime.Text = Math.Round(nudPlannedDistance.Value / Convert.ToDecimal(txtTrackSpd.Text), 2).ToString();
            txtExtJnyFuel.Text = Math.Round(Convert.ToDecimal(txtEstJnyTime.Text) * Convert.ToDecimal(txtFlowRate.Text), 0).ToString();
            txtAdjustedFuel.Text= Math.Round(((nudDistanceToAlternative.Value / nudCruiseSpeed.Value) + (nudReserve.Value / 60) + Convert.ToDecimal(txtEstJnyTime.Text)) * Convert.ToDecimal(txtFlowRate.Text), 0).ToString();
            txtAdj_TOW.Text = Math.Round(Convert.ToDecimal(txtAdjustedFuel.Text) + nudEmptyWeight.Value + nudCabinWeight.Value + nudCargo.Value, 0).ToString();
            if (Convert.ToDecimal(txtAdj_TOW.Text) > Convert.ToDecimal(nudAircraftMaxTO.Value))
            {
                txtAdj_TOW.BackColor = Color.Red;
            }
            else
            {
                txtAdj_TOW.BackColor = Color.Gainsboro;
            }
            if(Convert.ToDecimal(txtAdjustedFuel.Text) > nudMaxFuel.Value)
            {
                txtAdjustedFuel.BackColor = Color.Red;
            }
            else
            {
                txtAdjustedFuel.BackColor = Color.Gainsboro;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string vbCr = System.Environment.NewLine;
            MessageBox.Show("General Help" + vbCr +
               "Select an Aircraft to set up standard aircraft parameter" + vbCr +
               "these can be changed to match your actual parameters." + vbCr +
               "Provide Journey details and Takeoff requirements" + vbCr +
               "Use current weather to modify flight speed and time." + vbCr +
               "(Note wind direction is that the wind is blowing to" + vbCr +
               "not coming from as is the ususal convention). " + vbCr +
               "Review selected fuel requirements with the [Review] button." + vbCr +
               "When to start descent and slowing down can be calculated by providing the details." + vbCr +
               "Rollover each field for appropriate tool tips", "Help");
        }
        
        private void btnAbout_Click(object sender, EventArgs e )
        {
            MessageBox.Show("Flight and Fuel Planner Version " + lblVersion.Text + " by D.Parsons",  "About");
        }
    }



}
