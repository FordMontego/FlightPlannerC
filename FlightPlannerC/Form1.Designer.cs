namespace FlightPlannerC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbxPlane = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.nudMaxRange = new System.Windows.Forms.NumericUpDown();
            this.nudCruiseSpeed = new System.Windows.Forms.NumericUpDown();
            this.txtTimeAloft = new System.Windows.Forms.TextBox();
            this.nudMaxFuel = new System.Windows.Forms.NumericUpDown();
            this.txtFlowRate = new System.Windows.Forms.TextBox();
            this.nudPlannedDistance = new System.Windows.Forms.NumericUpDown();
            this.nudDistanceToAlternative = new System.Windows.Forms.NumericUpDown();
            this.nudReserve = new System.Windows.Forms.NumericUpDown();
            this.txtCalcRange = new System.Windows.Forms.TextBox();
            this.txtEstTime = new System.Windows.Forms.TextBox();
            this.txtFuelNeeded = new System.Windows.Forms.TextBox();
            this.nudEmptyWeight = new System.Windows.Forms.NumericUpDown();
            this.grpWeight = new System.Windows.Forms.GroupBox();
            this.txtSpareWeight = new System.Windows.Forms.TextBox();
            this.nudAircraftMaxTO = new System.Windows.Forms.NumericUpDown();
            this.txtTOWeight = new System.Windows.Forms.TextBox();
            this.nudCargo = new System.Windows.Forms.NumericUpDown();
            this.nudCabinWeight = new System.Windows.Forms.NumericUpDown();
            this.lblSpareWeight = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHeadDir = new System.Windows.Forms.TextBox();
            this.nudHeadDir = new System.Windows.Forms.NumericUpDown();
            this.nudWindDir = new System.Windows.Forms.NumericUpDown();
            this.nudTrackDir = new System.Windows.Forms.NumericUpDown();
            this.txtTrackDir = new System.Windows.Forms.TextBox();
            this.nudHeadSpd = new System.Windows.Forms.NumericUpDown();
            this.txtHeadSpd = new System.Windows.Forms.TextBox();
            this.nudWindSpd = new System.Windows.Forms.NumericUpDown();
            this.nudTrackSpd = new System.Windows.Forms.NumericUpDown();
            this.txtTrackSpd = new System.Windows.Forms.TextBox();
            this.rbuHead = new System.Windows.Forms.RadioButton();
            this.rbuTrack = new System.Windows.Forms.RadioButton();
            this.nudCruiseAlt = new System.Windows.Forms.NumericUpDown();
            this.nudRoD = new System.Windows.Forms.NumericUpDown();
            this.txtEstJnyTime = new System.Windows.Forms.TextBox();
            this.txtExtJnyFuel = new System.Windows.Forms.TextBox();
            this.txtAdjustedFuel = new System.Windows.Forms.TextBox();
            this.txtAdj_TOW = new System.Windows.Forms.TextBox();
            this.nudLandSpd = new System.Windows.Forms.NumericUpDown();
            this.nudAirportAlt = new System.Windows.Forms.NumericUpDown();
            this.txtDtoDesc = new System.Windows.Forms.TextBox();
            this.btReview = new System.Windows.Forms.Button();
            this.grpConsumption = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpFuel = new System.Windows.Forms.GroupBox();
            this.lblFuelNeeded = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCalcRange = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpTrak = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.grpDescent = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.grpReview = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.statusBar1 = new System.Windows.Forms.StatusStrip();
            this.epFuel = new System.Windows.Forms.ErrorProvider(this.components);
            this.epRange = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWeight = new System.Windows.Forms.ErrorProvider(this.components);
            this.epAlternative = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDescentRange = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCruiseSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxFuel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlannedDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistanceToAlternative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReserve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmptyWeight)).BeginInit();
            this.grpWeight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAircraftMaxTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCabinWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeadDir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindDir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrackDir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeadSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrackSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCruiseAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLandSpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAirportAlt)).BeginInit();
            this.grpConsumption.SuspendLayout();
            this.grpFuel.SuspendLayout();
            this.grpTrak.SuspendLayout();
            this.grpDescent.SuspendLayout();
            this.grpReview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epFuel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAlternative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDescentRange)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxPlane
            // 
            this.cbxPlane.FormattingEnabled = true;
            this.cbxPlane.Items.AddRange(new object[] {
            "Beechcraft Baron 58",
            "Beechcraft King Air 350",
            "Cessna C172SP Skyhawk",
            "Cessna C182S Skylane",
            "Cessna C208 Caravan Amphibian",
            "Cessna C208B Grand Caravan",
            "Mooney Bravo",
            "Other"});
            this.cbxPlane.Location = new System.Drawing.Point(23, 12);
            this.cbxPlane.Name = "cbxPlane";
            this.cbxPlane.Size = new System.Drawing.Size(191, 21);
            this.cbxPlane.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cbxPlane, "Select Plane for Standard Parameters");
            this.cbxPlane.SelectedIndexChanged += new System.EventHandler(this.cbxPlane_SelectedIndexChanged);
            // 
            // nudMaxRange
            // 
            this.nudMaxRange.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMaxRange.Location = new System.Drawing.Point(76, 17);
            this.nudMaxRange.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMaxRange.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudMaxRange.Name = "nudMaxRange";
            this.nudMaxRange.Size = new System.Drawing.Size(67, 20);
            this.nudMaxRange.TabIndex = 1;
            this.nudMaxRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.nudMaxRange, "Select maximum flying range");
            this.nudMaxRange.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudMaxRange.ValueChanged += new System.EventHandler(this.RangeChanged);
            // 
            // nudCruiseSpeed
            // 
            this.nudCruiseSpeed.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudCruiseSpeed.Location = new System.Drawing.Point(89, 43);
            this.nudCruiseSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCruiseSpeed.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudCruiseSpeed.Name = "nudCruiseSpeed";
            this.nudCruiseSpeed.Size = new System.Drawing.Size(54, 20);
            this.nudCruiseSpeed.TabIndex = 2;
            this.nudCruiseSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.nudCruiseSpeed, "Select Cruise speed");
            this.nudCruiseSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudCruiseSpeed.ValueChanged += new System.EventHandler(this.RangeChanged);
            // 
            // txtTimeAloft
            // 
            this.txtTimeAloft.Location = new System.Drawing.Point(89, 68);
            this.txtTimeAloft.Name = "txtTimeAloft";
            this.txtTimeAloft.ReadOnly = true;
            this.txtTimeAloft.Size = new System.Drawing.Size(54, 20);
            this.txtTimeAloft.TabIndex = 6;
            this.txtTimeAloft.TabStop = false;
            this.txtTimeAloft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtTimeAloft, "Shows maximum time aloft");
            // 
            // nudMaxFuel
            // 
            this.nudMaxFuel.Location = new System.Drawing.Point(89, 113);
            this.nudMaxFuel.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudMaxFuel.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMaxFuel.Name = "nudMaxFuel";
            this.nudMaxFuel.Size = new System.Drawing.Size(54, 20);
            this.nudMaxFuel.TabIndex = 3;
            this.nudMaxFuel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.nudMaxFuel, "Select total fuel capacity (all tanks)");
            this.nudMaxFuel.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMaxFuel.ValueChanged += new System.EventHandler(this.RangeChanged);
            // 
            // txtFlowRate
            // 
            this.txtFlowRate.Location = new System.Drawing.Point(89, 139);
            this.txtFlowRate.Name = "txtFlowRate";
            this.txtFlowRate.ReadOnly = true;
            this.txtFlowRate.Size = new System.Drawing.Size(54, 20);
            this.txtFlowRate.TabIndex = 7;
            this.txtFlowRate.TabStop = false;
            this.txtFlowRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtFlowRate, "Shows calculated fuel flow rate");
            // 
            // nudPlannedDistance
            // 
            this.nudPlannedDistance.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPlannedDistance.Location = new System.Drawing.Point(111, 17);
            this.nudPlannedDistance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPlannedDistance.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPlannedDistance.Name = "nudPlannedDistance";
            this.nudPlannedDistance.Size = new System.Drawing.Size(58, 20);
            this.nudPlannedDistance.TabIndex = 4;
            this.nudPlannedDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.nudPlannedDistance, "Planned journey distance");
            this.nudPlannedDistance.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPlannedDistance.ValueChanged += new System.EventHandler(this.RangeChanged);
            // 
            // nudDistanceToAlternative
            // 
            this.nudDistanceToAlternative.Location = new System.Drawing.Point(111, 43);
            this.nudDistanceToAlternative.Name = "nudDistanceToAlternative";
            this.nudDistanceToAlternative.Size = new System.Drawing.Size(58, 20);
            this.nudDistanceToAlternative.TabIndex = 5;
            this.nudDistanceToAlternative.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.nudDistanceToAlternative, "Distance from destination to alternative");
            this.nudDistanceToAlternative.ValueChanged += new System.EventHandler(this.RangeChanged);
            // 
            // nudReserve
            // 
            this.nudReserve.Location = new System.Drawing.Point(111, 69);
            this.nudReserve.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudReserve.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudReserve.Name = "nudReserve";
            this.nudReserve.Size = new System.Drawing.Size(58, 20);
            this.nudReserve.TabIndex = 6;
            this.nudReserve.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.nudReserve, "Reserve flying time to be left in tank upon landing (FAA/CAA requirements) + fuel" +
        " for pre and post flight operations");
            this.nudReserve.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudReserve.ValueChanged += new System.EventHandler(this.RangeChanged);
            // 
            // txtCalcRange
            // 
            this.txtCalcRange.Location = new System.Drawing.Point(111, 94);
            this.txtCalcRange.Name = "txtCalcRange";
            this.txtCalcRange.ReadOnly = true;
            this.txtCalcRange.Size = new System.Drawing.Size(58, 20);
            this.txtCalcRange.TabIndex = 8;
            this.txtCalcRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtCalcRange, "Estimated range of flight, plus diversion plus using reserve (Will be less due to" +
        " greater burn rate at take off and climbing)");
            // 
            // txtEstTime
            // 
            this.txtEstTime.Location = new System.Drawing.Point(111, 117);
            this.txtEstTime.Name = "txtEstTime";
            this.txtEstTime.ReadOnly = true;
            this.txtEstTime.Size = new System.Drawing.Size(58, 20);
            this.txtEstTime.TabIndex = 9;
            this.txtEstTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtEstTime, "Estimated flying time at cruise speed to cover range (will be longer due to lower" +
        " take off and landing speeds)");
            // 
            // txtFuelNeeded
            // 
            this.txtFuelNeeded.Location = new System.Drawing.Point(111, 149);
            this.txtFuelNeeded.Name = "txtFuelNeeded";
            this.txtFuelNeeded.ReadOnly = true;
            this.txtFuelNeeded.Size = new System.Drawing.Size(58, 20);
            this.txtFuelNeeded.TabIndex = 7;
            this.txtFuelNeeded.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtFuelNeeded, "Minimum fuel requirements for flight + diversion at cruise  flow rate + reserve");
            // 
            // nudEmptyWeight
            // 
            this.nudEmptyWeight.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudEmptyWeight.Location = new System.Drawing.Point(108, 19);
            this.nudEmptyWeight.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudEmptyWeight.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudEmptyWeight.Name = "nudEmptyWeight";
            this.nudEmptyWeight.Size = new System.Drawing.Size(58, 20);
            this.nudEmptyWeight.TabIndex = 7;
            this.nudEmptyWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.nudEmptyWeight, "Empty weight of aircraft7");
            this.nudEmptyWeight.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudEmptyWeight.ValueChanged += new System.EventHandler(this.Weight_Changed);
            // 
            // grpWeight
            // 
            this.grpWeight.Controls.Add(this.txtSpareWeight);
            this.grpWeight.Controls.Add(this.nudAircraftMaxTO);
            this.grpWeight.Controls.Add(this.txtTOWeight);
            this.grpWeight.Controls.Add(this.nudCargo);
            this.grpWeight.Controls.Add(this.nudCabinWeight);
            this.grpWeight.Controls.Add(this.nudEmptyWeight);
            this.grpWeight.Controls.Add(this.lblSpareWeight);
            this.grpWeight.Controls.Add(this.label14);
            this.grpWeight.Controls.Add(this.label13);
            this.grpWeight.Controls.Add(this.label12);
            this.grpWeight.Controls.Add(this.label11);
            this.grpWeight.Controls.Add(this.label10);
            this.grpWeight.Location = new System.Drawing.Point(379, 39);
            this.grpWeight.Name = "grpWeight";
            this.grpWeight.Size = new System.Drawing.Size(183, 181);
            this.grpWeight.TabIndex = 3;
            this.grpWeight.TabStop = false;
            this.grpWeight.Text = "Take Off Weight";
            this.toolTip1.SetToolTip(this.grpWeight, "total weight of pilot, crew and passengers");
            // 
            // txtSpareWeight
            // 
            this.txtSpareWeight.Location = new System.Drawing.Point(108, 149);
            this.txtSpareWeight.Name = "txtSpareWeight";
            this.txtSpareWeight.ReadOnly = true;
            this.txtSpareWeight.Size = new System.Drawing.Size(58, 20);
            this.txtSpareWeight.TabIndex = 10;
            this.txtSpareWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtSpareWeight, "Calculated spare capacity (maximum less calculated take off weight)");
            // 
            // nudAircraftMaxTO
            // 
            this.nudAircraftMaxTO.Location = new System.Drawing.Point(108, 123);
            this.nudAircraftMaxTO.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudAircraftMaxTO.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAircraftMaxTO.Name = "nudAircraftMaxTO";
            this.nudAircraftMaxTO.Size = new System.Drawing.Size(58, 20);
            this.nudAircraftMaxTO.TabIndex = 11;
            this.nudAircraftMaxTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.nudAircraftMaxTO, "Maximum designed takeoff weight");
            this.nudAircraftMaxTO.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudAircraftMaxTO.ValueChanged += new System.EventHandler(this.Weight_Changed);
            // 
            // txtTOWeight
            // 
            this.txtTOWeight.Location = new System.Drawing.Point(108, 97);
            this.txtTOWeight.Name = "txtTOWeight";
            this.txtTOWeight.ReadOnly = true;
            this.txtTOWeight.Size = new System.Drawing.Size(58, 20);
            this.txtTOWeight.TabIndex = 10;
            this.txtTOWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtTOWeight, "Calculated weight at take off: plane, fuel(Calculated), passengers and cargo");
            // 
            // nudCargo
            // 
            this.nudCargo.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCargo.Location = new System.Drawing.Point(108, 68);
            this.nudCargo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCargo.Name = "nudCargo";
            this.nudCargo.Size = new System.Drawing.Size(58, 20);
            this.nudCargo.TabIndex = 9;
            this.nudCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.nudCargo, "Total weight of cargo (across all holds)");
            this.nudCargo.ValueChanged += new System.EventHandler(this.Weight_Changed);
            // 
            // nudCabinWeight
            // 
            this.nudCabinWeight.Location = new System.Drawing.Point(108, 45);
            this.nudCabinWeight.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.nudCabinWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudCabinWeight.Name = "nudCabinWeight";
            this.nudCabinWeight.Size = new System.Drawing.Size(58, 20);
            this.nudCabinWeight.TabIndex = 8;
            this.nudCabinWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.nudCabinWeight, "Weight of people: Crew and passengers");
            this.nudCabinWeight.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudCabinWeight.ValueChanged += new System.EventHandler(this.Weight_Changed);
            // 
            // lblSpareWeight
            // 
            this.lblSpareWeight.AutoSize = true;
            this.lblSpareWeight.Location = new System.Drawing.Point(6, 152);
            this.lblSpareWeight.Name = "lblSpareWeight";
            this.lblSpareWeight.Size = new System.Drawing.Size(101, 13);
            this.lblSpareWeight.TabIndex = 5;
            this.lblSpareWeight.Text = "Spare Capacity (lbs)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Specified T/O (lbs)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Take-Off Weight";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Cargo (lbs)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "People (lbs)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Empty Weight (lb)";
            // 
            // txtHeadDir
            // 
            this.txtHeadDir.BackColor = System.Drawing.Color.White;
            this.txtHeadDir.Location = new System.Drawing.Point(68, 29);
            this.txtHeadDir.Name = "txtHeadDir";
            this.txtHeadDir.ReadOnly = true;
            this.txtHeadDir.Size = new System.Drawing.Size(46, 20);
            this.txtHeadDir.TabIndex = 11;
            this.txtHeadDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtHeadDir, "Direction of Flight");
            // 
            // nudHeadDir
            // 
            this.nudHeadDir.Location = new System.Drawing.Point(68, 29);
            this.nudHeadDir.Maximum = new decimal(new int[] {
            361,
            0,
            0,
            0});
            this.nudHeadDir.Name = "nudHeadDir";
            this.nudHeadDir.Size = new System.Drawing.Size(61, 20);
            this.nudHeadDir.TabIndex = 11;
            this.nudHeadDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.nudHeadDir, "Direction of flight");
            this.nudHeadDir.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudHeadDir.ValueChanged += new System.EventHandler(this.Vectors_Changed);
            // 
            // nudWindDir
            // 
            this.nudWindDir.Location = new System.Drawing.Point(69, 56);
            this.nudWindDir.Maximum = new decimal(new int[] {
            361,
            0,
            0,
            0});
            this.nudWindDir.Name = "nudWindDir";
            this.nudWindDir.Size = new System.Drawing.Size(61, 20);
            this.nudWindDir.TabIndex = 12;
            this.nudWindDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.nudWindDir, "Direction of wind (ie its head to not from as the usual notation)");
            this.nudWindDir.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudWindDir.ValueChanged += new System.EventHandler(this.Vectors_Changed);
            // 
            // nudTrackDir
            // 
            this.nudTrackDir.Location = new System.Drawing.Point(68, 82);
            this.nudTrackDir.Maximum = new decimal(new int[] {
            361,
            0,
            0,
            0});
            this.nudTrackDir.Name = "nudTrackDir";
            this.nudTrackDir.Size = new System.Drawing.Size(61, 20);
            this.nudTrackDir.TabIndex = 13;
            this.nudTrackDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.nudTrackDir, "Track over Ground");
            this.nudTrackDir.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudTrackDir.ValueChanged += new System.EventHandler(this.Vectors_Changed);
            // 
            // txtTrackDir
            // 
            this.txtTrackDir.BackColor = System.Drawing.Color.White;
            this.txtTrackDir.Location = new System.Drawing.Point(68, 82);
            this.txtTrackDir.Name = "txtTrackDir";
            this.txtTrackDir.ReadOnly = true;
            this.txtTrackDir.Size = new System.Drawing.Size(46, 20);
            this.txtTrackDir.TabIndex = 14;
            this.txtTrackDir.Text = "360";
            this.txtTrackDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtTrackDir, "Track over ground");
            // 
            // nudHeadSpd
            // 
            this.nudHeadSpd.Location = new System.Drawing.Point(145, 30);
            this.nudHeadSpd.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudHeadSpd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHeadSpd.Name = "nudHeadSpd";
            this.nudHeadSpd.Size = new System.Drawing.Size(57, 20);
            this.nudHeadSpd.TabIndex = 15;
            this.nudHeadSpd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.nudHeadSpd, "Airspeed");
            this.nudHeadSpd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHeadSpd.ValueChanged += new System.EventHandler(this.Vectors_Changed);
            // 
            // txtHeadSpd
            // 
            this.txtHeadSpd.BackColor = System.Drawing.Color.White;
            this.txtHeadSpd.Location = new System.Drawing.Point(145, 30);
            this.txtHeadSpd.Name = "txtHeadSpd";
            this.txtHeadSpd.ReadOnly = true;
            this.txtHeadSpd.Size = new System.Drawing.Size(41, 20);
            this.txtHeadSpd.TabIndex = 17;
            this.txtHeadSpd.Text = "1";
            this.txtHeadSpd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtHeadSpd, "Airspeed");
            this.txtHeadSpd.TextChanged += new System.EventHandler(this.Vectors_Changed);
            // 
            // nudWindSpd
            // 
            this.nudWindSpd.Location = new System.Drawing.Point(145, 56);
            this.nudWindSpd.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudWindSpd.Name = "nudWindSpd";
            this.nudWindSpd.Size = new System.Drawing.Size(57, 20);
            this.nudWindSpd.TabIndex = 18;
            this.nudWindSpd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.nudWindSpd, "Speed of Wind");
            this.nudWindSpd.ValueChanged += new System.EventHandler(this.Vectors_Changed);
            // 
            // nudTrackSpd
            // 
            this.nudTrackSpd.Location = new System.Drawing.Point(145, 82);
            this.nudTrackSpd.Maximum = new decimal(new int[] {
            361,
            0,
            0,
            0});
            this.nudTrackSpd.Name = "nudTrackSpd";
            this.nudTrackSpd.Size = new System.Drawing.Size(57, 20);
            this.nudTrackSpd.TabIndex = 19;
            this.nudTrackSpd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.nudTrackSpd, "Groundspeed");
            this.nudTrackSpd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTrackSpd.ValueChanged += new System.EventHandler(this.Vectors_Changed);
            // 
            // txtTrackSpd
            // 
            this.txtTrackSpd.BackColor = System.Drawing.Color.White;
            this.txtTrackSpd.Location = new System.Drawing.Point(145, 82);
            this.txtTrackSpd.Name = "txtTrackSpd";
            this.txtTrackSpd.ReadOnly = true;
            this.txtTrackSpd.Size = new System.Drawing.Size(41, 20);
            this.txtTrackSpd.TabIndex = 20;
            this.txtTrackSpd.Text = "1";
            this.txtTrackSpd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtTrackSpd, "Groundspeed");
            // 
            // rbuHead
            // 
            this.rbuHead.AutoSize = true;
            this.rbuHead.Location = new System.Drawing.Point(243, 32);
            this.rbuHead.Name = "rbuHead";
            this.rbuHead.Size = new System.Drawing.Size(14, 13);
            this.rbuHead.TabIndex = 22;
            this.rbuHead.TabStop = true;
            this.toolTip1.SetToolTip(this.rbuHead, "Calculate heading and speed to acheive track");
            this.rbuHead.UseVisualStyleBackColor = true;
            this.rbuHead.CheckedChanged += new System.EventHandler(this.rbuHead_CheckedChanged);
            // 
            // rbuTrack
            // 
            this.rbuTrack.AutoSize = true;
            this.rbuTrack.Location = new System.Drawing.Point(243, 84);
            this.rbuTrack.Name = "rbuTrack";
            this.rbuTrack.Size = new System.Drawing.Size(14, 13);
            this.rbuTrack.TabIndex = 23;
            this.rbuTrack.TabStop = true;
            this.toolTip1.SetToolTip(this.rbuTrack, "Calculate track over ground");
            this.rbuTrack.UseVisualStyleBackColor = true;
            this.rbuTrack.CheckedChanged += new System.EventHandler(this.rbuTrack_CheckedChanged);
            // 
            // nudCruiseAlt
            // 
            this.nudCruiseAlt.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudCruiseAlt.Location = new System.Drawing.Point(82, 14);
            this.nudCruiseAlt.Maximum = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            this.nudCruiseAlt.Name = "nudCruiseAlt";
            this.nudCruiseAlt.Size = new System.Drawing.Size(61, 20);
            this.nudCruiseAlt.TabIndex = 24;
            this.nudCruiseAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.nudCruiseAlt, "Cruising Alt at Start of Descent");
            this.nudCruiseAlt.ValueChanged += new System.EventHandler(this.Descent_Range);
            // 
            // nudRoD
            // 
            this.nudRoD.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudRoD.Location = new System.Drawing.Point(82, 37);
            this.nudRoD.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.nudRoD.Name = "nudRoD";
            this.nudRoD.Size = new System.Drawing.Size(61, 20);
            this.nudRoD.TabIndex = 25;
            this.nudRoD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.nudRoD, "Fate of Descent (ft/Min)");
            this.nudRoD.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudRoD.ValueChanged += new System.EventHandler(this.Descent_Range);
            // 
            // txtEstJnyTime
            // 
            this.txtEstJnyTime.Location = new System.Drawing.Point(121, 55);
            this.txtEstJnyTime.Name = "txtEstJnyTime";
            this.txtEstJnyTime.ReadOnly = true;
            this.txtEstJnyTime.Size = new System.Drawing.Size(77, 20);
            this.txtEstJnyTime.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtEstJnyTime, "Estimated journey time");
            // 
            // txtExtJnyFuel
            // 
            this.txtExtJnyFuel.Location = new System.Drawing.Point(121, 80);
            this.txtExtJnyFuel.Name = "txtExtJnyFuel";
            this.txtExtJnyFuel.ReadOnly = true;
            this.txtExtJnyFuel.Size = new System.Drawing.Size(77, 20);
            this.txtExtJnyFuel.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtExtJnyFuel, "Estimated fuel for journey");
            // 
            // txtAdjustedFuel
            // 
            this.txtAdjustedFuel.Location = new System.Drawing.Point(121, 106);
            this.txtAdjustedFuel.Name = "txtAdjustedFuel";
            this.txtAdjustedFuel.ReadOnly = true;
            this.txtAdjustedFuel.Size = new System.Drawing.Size(77, 20);
            this.txtAdjustedFuel.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtAdjustedFuel, "Adjusted total fuel requirement for new journey file, diversion and reserve");
            // 
            // txtAdj_TOW
            // 
            this.txtAdj_TOW.Location = new System.Drawing.Point(121, 132);
            this.txtAdj_TOW.Name = "txtAdj_TOW";
            this.txtAdj_TOW.ReadOnly = true;
            this.txtAdj_TOW.Size = new System.Drawing.Size(77, 20);
            this.txtAdj_TOW.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtAdj_TOW, "Adjusted take off weight using revised fuel weight");
            // 
            // nudLandSpd
            // 
            this.nudLandSpd.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLandSpd.Location = new System.Drawing.Point(212, 39);
            this.nudLandSpd.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudLandSpd.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudLandSpd.Name = "nudLandSpd";
            this.nudLandSpd.Size = new System.Drawing.Size(70, 20);
            this.nudLandSpd.TabIndex = 31;
            this.nudLandSpd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.nudLandSpd, "Landing speed");
            this.nudLandSpd.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nudLandSpd.ValueChanged += new System.EventHandler(this.Descent_Range);
            // 
            // nudAirportAlt
            // 
            this.nudAirportAlt.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudAirportAlt.Location = new System.Drawing.Point(212, 14);
            this.nudAirportAlt.Maximum = new decimal(new int[] {
            25000,
            0,
            0,
            0});
            this.nudAirportAlt.Name = "nudAirportAlt";
            this.nudAirportAlt.Size = new System.Drawing.Size(70, 20);
            this.nudAirportAlt.TabIndex = 30;
            this.nudAirportAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.nudAirportAlt, "Altitude of intended airport");
            this.nudAirportAlt.ValueChanged += new System.EventHandler(this.Descent_Range);
            // 
            // txtDtoDesc
            // 
            this.txtDtoDesc.Location = new System.Drawing.Point(115, 63);
            this.txtDtoDesc.Name = "txtDtoDesc";
            this.txtDtoDesc.ReadOnly = true;
            this.txtDtoDesc.Size = new System.Drawing.Size(71, 20);
            this.txtDtoDesc.TabIndex = 27;
            this.txtDtoDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtDtoDesc, "Distance at which to commence descent");
            // 
            // btReview
            // 
            this.btReview.Location = new System.Drawing.Point(67, 18);
            this.btReview.Name = "btReview";
            this.btReview.Size = new System.Drawing.Size(75, 23);
            this.btReview.TabIndex = 0;
            this.btReview.Text = "&Review";
            this.toolTip1.SetToolTip(this.btReview, "Review fuel/weight estimates");
            this.btReview.UseVisualStyleBackColor = true;
            this.btReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // grpConsumption
            // 
            this.grpConsumption.Controls.Add(this.txtFlowRate);
            this.grpConsumption.Controls.Add(this.nudMaxFuel);
            this.grpConsumption.Controls.Add(this.txtTimeAloft);
            this.grpConsumption.Controls.Add(this.nudCruiseSpeed);
            this.grpConsumption.Controls.Add(this.nudMaxRange);
            this.grpConsumption.Controls.Add(this.label5);
            this.grpConsumption.Controls.Add(this.label4);
            this.grpConsumption.Controls.Add(this.label3);
            this.grpConsumption.Controls.Add(this.label2);
            this.grpConsumption.Controls.Add(this.label1);
            this.grpConsumption.Location = new System.Drawing.Point(12, 39);
            this.grpConsumption.Name = "grpConsumption";
            this.grpConsumption.Size = new System.Drawing.Size(169, 181);
            this.grpConsumption.TabIndex = 1;
            this.grpConsumption.TabStop = false;
            this.grpConsumption.Text = "Fuel Consumption";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Flow rate (lb/hr)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Max Fuel (lb)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time Aloft";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cruise Spd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max Range";
            // 
            // grpFuel
            // 
            this.grpFuel.Controls.Add(this.txtFuelNeeded);
            this.grpFuel.Controls.Add(this.txtEstTime);
            this.grpFuel.Controls.Add(this.txtCalcRange);
            this.grpFuel.Controls.Add(this.nudReserve);
            this.grpFuel.Controls.Add(this.nudDistanceToAlternative);
            this.grpFuel.Controls.Add(this.nudPlannedDistance);
            this.grpFuel.Controls.Add(this.lblFuelNeeded);
            this.grpFuel.Controls.Add(this.panel1);
            this.grpFuel.Controls.Add(this.label9);
            this.grpFuel.Controls.Add(this.lblCalcRange);
            this.grpFuel.Controls.Add(this.label8);
            this.grpFuel.Controls.Add(this.label7);
            this.grpFuel.Controls.Add(this.label6);
            this.grpFuel.Location = new System.Drawing.Point(187, 39);
            this.grpFuel.Name = "grpFuel";
            this.grpFuel.Size = new System.Drawing.Size(183, 181);
            this.grpFuel.TabIndex = 2;
            this.grpFuel.TabStop = false;
            this.grpFuel.Text = "Fuel Requirement";
            // 
            // lblFuelNeeded
            // 
            this.lblFuelNeeded.AutoSize = true;
            this.lblFuelNeeded.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelNeeded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.lblFuelNeeded.Location = new System.Drawing.Point(6, 152);
            this.lblFuelNeeded.Name = "lblFuelNeeded";
            this.lblFuelNeeded.Size = new System.Drawing.Size(101, 13);
            this.lblFuelNeeded.TabIndex = 6;
            this.lblFuelNeeded.Text = "Fuel Needed (lb)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(0, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 1);
            this.panel1.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Estimated Time";
            // 
            // lblCalcRange
            // 
            this.lblCalcRange.AutoSize = true;
            this.lblCalcRange.Location = new System.Drawing.Point(6, 97);
            this.lblCalcRange.Name = "lblCalcRange";
            this.lblCalcRange.Size = new System.Drawing.Size(63, 13);
            this.lblCalcRange.TabIndex = 3;
            this.lblCalcRange.Text = "Calc Range";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Reserve (mins)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "To Alternative (nm)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Planned (nm)";
            // 
            // grpTrak
            // 
            this.grpTrak.Controls.Add(this.rbuTrack);
            this.grpTrak.Controls.Add(this.rbuHead);
            this.grpTrak.Controls.Add(this.label21);
            this.grpTrak.Controls.Add(this.txtTrackSpd);
            this.grpTrak.Controls.Add(this.nudTrackSpd);
            this.grpTrak.Controls.Add(this.nudWindSpd);
            this.grpTrak.Controls.Add(this.txtHeadSpd);
            this.grpTrak.Controls.Add(this.label20);
            this.grpTrak.Controls.Add(this.txtTrackDir);
            this.grpTrak.Controls.Add(this.nudHeadSpd);
            this.grpTrak.Controls.Add(this.nudTrackDir);
            this.grpTrak.Controls.Add(this.nudWindDir);
            this.grpTrak.Controls.Add(this.nudHeadDir);
            this.grpTrak.Controls.Add(this.txtHeadDir);
            this.grpTrak.Controls.Add(this.label19);
            this.grpTrak.Controls.Add(this.label18);
            this.grpTrak.Controls.Add(this.label17);
            this.grpTrak.Controls.Add(this.label16);
            this.grpTrak.Location = new System.Drawing.Point(12, 226);
            this.grpTrak.Name = "grpTrak";
            this.grpTrak.Size = new System.Drawing.Size(297, 114);
            this.grpTrak.TabIndex = 11;
            this.grpTrak.TabStop = false;
            this.grpTrak.Text = "Heading/Track Calculator";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(222, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 13);
            this.label21.TabIndex = 21;
            this.label21.Text = "Calculate";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(141, 14);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "Speed (kn)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(65, 14);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "Direction";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(27, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Track";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Wind (from)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Heading";
            // 
            // grpDescent
            // 
            this.grpDescent.Controls.Add(this.nudLandSpd);
            this.grpDescent.Controls.Add(this.nudAirportAlt);
            this.grpDescent.Controls.Add(this.label26);
            this.grpDescent.Controls.Add(this.label25);
            this.grpDescent.Controls.Add(this.txtDtoDesc);
            this.grpDescent.Controls.Add(this.label24);
            this.grpDescent.Controls.Add(this.nudRoD);
            this.grpDescent.Controls.Add(this.nudCruiseAlt);
            this.grpDescent.Controls.Add(this.label23);
            this.grpDescent.Controls.Add(this.label22);
            this.grpDescent.Location = new System.Drawing.Point(12, 339);
            this.grpDescent.Name = "grpDescent";
            this.grpDescent.Size = new System.Drawing.Size(297, 91);
            this.grpDescent.TabIndex = 12;
            this.grpDescent.TabStop = false;
            this.grpDescent.Text = "Start of Descent";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(154, 39);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 13);
            this.label26.TabIndex = 29;
            this.label26.Text = "Land Spd";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(154, 16);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 13);
            this.label25.TabIndex = 28;
            this.label25.Text = "A/port Alt";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(41, 66);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 13);
            this.label24.TabIndex = 26;
            this.label24.Text = "Dist for Desc";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 39);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "Rate of Desc";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Cruise Alt";
            // 
            // grpReview
            // 
            this.grpReview.Controls.Add(this.txtAdj_TOW);
            this.grpReview.Controls.Add(this.txtAdjustedFuel);
            this.grpReview.Controls.Add(this.txtExtJnyFuel);
            this.grpReview.Controls.Add(this.txtEstJnyTime);
            this.grpReview.Controls.Add(this.label30);
            this.grpReview.Controls.Add(this.label29);
            this.grpReview.Controls.Add(this.label28);
            this.grpReview.Controls.Add(this.label27);
            this.grpReview.Controls.Add(this.btReview);
            this.grpReview.Location = new System.Drawing.Point(343, 226);
            this.grpReview.Name = "grpReview";
            this.grpReview.Size = new System.Drawing.Size(219, 169);
            this.grpReview.TabIndex = 13;
            this.grpReview.TabStop = false;
            this.grpReview.Text = "Review Fuel\\Weight";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(22, 135);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(88, 13);
            this.label30.TabIndex = 4;
            this.label30.Text = "Adjusted T/O Wt";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(22, 109);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(71, 13);
            this.label29.TabIndex = 3;
            this.label29.Text = "Adjusted Fuel";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(22, 83);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(79, 13);
            this.label28.TabIndex = 2;
            this.label28.Text = "Est Fuel for Jny";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(22, 58);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(82, 13);
            this.label27.TabIndex = 1;
            this.label27.Text = "Est Time for Jny";
            // 
            // statusBar1
            // 
            this.statusBar1.BackColor = System.Drawing.Color.White;
            this.statusBar1.Location = new System.Drawing.Point(0, 430);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(565, 22);
            this.statusBar1.TabIndex = 14;
            this.statusBar1.Text = "statusBar1";
            // 
            // epFuel
            // 
            this.epFuel.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epFuel.ContainerControl = this;
            // 
            // epRange
            // 
            this.epRange.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epRange.ContainerControl = this;
            // 
            // epWeight
            // 
            this.epWeight.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epWeight.ContainerControl = this;
            // 
            // epAlternative
            // 
            this.epAlternative.ContainerControl = this;
            // 
            // epDescentRange
            // 
            this.epDescentRange.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epDescentRange.ContainerControl = this;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(504, 408);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(41, 13);
            this.lblVersion.TabIndex = 15;
            this.lblVersion.Text = "Ver 1.0";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(378, 10);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 16;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(470, 10);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 17;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 452);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.grpReview);
            this.Controls.Add(this.grpDescent);
            this.Controls.Add(this.grpTrak);
            this.Controls.Add(this.grpWeight);
            this.Controls.Add(this.grpFuel);
            this.Controls.Add(this.grpConsumption);
            this.Controls.Add(this.cbxPlane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(585, 495);
            this.MinimumSize = new System.Drawing.Size(585, 495);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fuel and Weight Planner";
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCruiseSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxFuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlannedDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistanceToAlternative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReserve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmptyWeight)).EndInit();
            this.grpWeight.ResumeLayout(false);
            this.grpWeight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAircraftMaxTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCabinWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeadDir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindDir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrackDir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeadSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrackSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCruiseAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLandSpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAirportAlt)).EndInit();
            this.grpConsumption.ResumeLayout(false);
            this.grpConsumption.PerformLayout();
            this.grpFuel.ResumeLayout(false);
            this.grpFuel.PerformLayout();
            this.grpTrak.ResumeLayout(false);
            this.grpTrak.PerformLayout();
            this.grpDescent.ResumeLayout(false);
            this.grpDescent.PerformLayout();
            this.grpReview.ResumeLayout(false);
            this.grpReview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epFuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAlternative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDescentRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPlane;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox grpConsumption;
        private System.Windows.Forms.NumericUpDown nudMaxRange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimeAloft;
        private System.Windows.Forms.NumericUpDown nudCruiseSpeed;
        private System.Windows.Forms.NumericUpDown nudMaxFuel;
        private System.Windows.Forms.TextBox txtFlowRate;
        private System.Windows.Forms.GroupBox grpFuel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudDistanceToAlternative;
        private System.Windows.Forms.NumericUpDown nudPlannedDistance;
        private System.Windows.Forms.Label lblFuelNeeded;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCalcRange;
        private System.Windows.Forms.TextBox txtFuelNeeded;
        private System.Windows.Forms.TextBox txtEstTime;
        private System.Windows.Forms.TextBox txtCalcRange;
        private System.Windows.Forms.NumericUpDown nudReserve;
        private System.Windows.Forms.GroupBox grpWeight;
        private System.Windows.Forms.NumericUpDown nudEmptyWeight;
        private System.Windows.Forms.Label lblSpareWeight;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSpareWeight;
        private System.Windows.Forms.NumericUpDown nudAircraftMaxTO;
        private System.Windows.Forms.TextBox txtTOWeight;
        private System.Windows.Forms.NumericUpDown nudCargo;
        private System.Windows.Forms.NumericUpDown nudCabinWeight;
        private System.Windows.Forms.GroupBox grpTrak;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nudWindDir;
        private System.Windows.Forms.NumericUpDown nudHeadDir;
        private System.Windows.Forms.TextBox txtHeadDir;
        private System.Windows.Forms.RadioButton rbuHead;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtTrackSpd;
        private System.Windows.Forms.NumericUpDown nudTrackSpd;
        private System.Windows.Forms.NumericUpDown nudWindSpd;
        private System.Windows.Forms.TextBox txtHeadSpd;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown nudHeadSpd;
        private System.Windows.Forms.TextBox txtTrackDir;
        private System.Windows.Forms.NumericUpDown nudTrackDir;
        private System.Windows.Forms.RadioButton rbuTrack;
        private System.Windows.Forms.GroupBox grpDescent;
        private System.Windows.Forms.NumericUpDown nudCruiseAlt;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown nudLandSpd;
        private System.Windows.Forms.NumericUpDown nudAirportAlt;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtDtoDesc;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown nudRoD;
        private System.Windows.Forms.GroupBox grpReview;
        private System.Windows.Forms.TextBox txtAdj_TOW;
        private System.Windows.Forms.TextBox txtAdjustedFuel;
        private System.Windows.Forms.TextBox txtExtJnyFuel;
        private System.Windows.Forms.TextBox txtEstJnyTime;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btReview;
        private System.Windows.Forms.StatusStrip statusBar1;
        private System.Windows.Forms.ErrorProvider epFuel;
        private System.Windows.Forms.ErrorProvider epRange;
        private System.Windows.Forms.ErrorProvider epWeight;
        private System.Windows.Forms.ErrorProvider epAlternative;
        private System.Windows.Forms.ErrorProvider epDescentRange;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnHelp;
    }
}

