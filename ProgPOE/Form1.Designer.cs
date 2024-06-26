namespace ProgPOE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnGetStarted = new Button();
            panel2 = new Panel();
            btnExit2 = new Button();
            btnAddRecipe = new Button();
            btnSetRecipe = new Button();
            UpDownCalories = new NumericUpDown();
            lblingreCalories = new Label();
            txtIngreFoodGroup = new TextBox();
            lblingrFoodGroup = new Label();
            btnClearIngre = new Button();
            btnClearStep = new Button();
            btnDisplayRecipe = new Button();
            btnAddStep = new Button();
            btnAddIngre = new Button();
            txtStepDescription = new TextBox();
            lblStepDescription = new Label();
            UpDownQuantity = new NumericUpDown();
            txtUnitOfMesaure = new TextBox();
            txtIngreName = new TextBox();
            lblIngreUnitofMeasure = new Label();
            lblIngreName = new Label();
            lblQuantity = new Label();
            UpDownSteps = new NumericUpDown();
            UpDownIngre = new NumericUpDown();
            lblStepNo = new Label();
            lblIngeNo = new Label();
            lblRecipeName = new Label();
            txtRecipeName = new TextBox();
            panel3 = new Panel();
            btnBackToAddRecipe = new Button();
            lbDisplayIngreAndSteps = new Label();
            btnChooseRecipe = new Button();
            txtRecipeName2 = new TextBox();
            btnClear = new Button();
            btnScale = new Button();
            panel4 = new Panel();
            btnBackToViewRecipe2 = new Button();
            lblScaleBy = new Label();
            btnTriple = new Button();
            btnHalf = new Button();
            btnDouble = new Button();
            btnResetRecipe = new Button();
            panel5 = new Panel();
            btnExit5 = new Button();
            lblListOfAllRecipes = new Label();
            btnBackToViewRecipe = new Button();
            lbDisplaySelectedRecipe = new Label();
            btnViewRecipe = new Button();
            lbRecipeOptions = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UpDownCalories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownSteps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpDownIngre).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnGetStarted);
            panel1.Location = new Point(27, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 333);
            panel1.TabIndex = 0;
            // 
            // btnGetStarted
            // 
            btnGetStarted.BackColor = SystemColors.ButtonFace;
            btnGetStarted.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGetStarted.Location = new Point(55, 118);
            btnGetStarted.Name = "btnGetStarted";
            btnGetStarted.Size = new Size(157, 82);
            btnGetStarted.TabIndex = 0;
            btnGetStarted.Text = "Get Your \r\nRecipe Started!";
            btnGetStarted.UseVisualStyleBackColor = false;
            btnGetStarted.Click += btnGetStarted_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.infoPage3;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(btnExit2);
            panel2.Controls.Add(btnAddRecipe);
            panel2.Controls.Add(btnSetRecipe);
            panel2.Controls.Add(UpDownCalories);
            panel2.Controls.Add(lblingreCalories);
            panel2.Controls.Add(txtIngreFoodGroup);
            panel2.Controls.Add(lblingrFoodGroup);
            panel2.Controls.Add(btnClearIngre);
            panel2.Controls.Add(btnClearStep);
            panel2.Controls.Add(btnDisplayRecipe);
            panel2.Controls.Add(btnAddStep);
            panel2.Controls.Add(btnAddIngre);
            panel2.Controls.Add(txtStepDescription);
            panel2.Controls.Add(lblStepDescription);
            panel2.Controls.Add(UpDownQuantity);
            panel2.Controls.Add(txtUnitOfMesaure);
            panel2.Controls.Add(txtIngreName);
            panel2.Controls.Add(lblIngreUnitofMeasure);
            panel2.Controls.Add(lblIngreName);
            panel2.Controls.Add(lblQuantity);
            panel2.Controls.Add(UpDownSteps);
            panel2.Controls.Add(UpDownIngre);
            panel2.Controls.Add(lblStepNo);
            panel2.Controls.Add(lblIngeNo);
            panel2.Controls.Add(lblRecipeName);
            panel2.Controls.Add(txtRecipeName);
            panel2.Location = new Point(312, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(266, 333);
            panel2.TabIndex = 1;
            // 
            // btnExit2
            // 
            btnExit2.BackColor = SystemColors.ButtonFace;
            btnExit2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit2.ForeColor = Color.Black;
            btnExit2.Location = new Point(202, 307);
            btnExit2.Name = "btnExit2";
            btnExit2.Size = new Size(61, 23);
            btnExit2.TabIndex = 31;
            btnExit2.Text = "Exit";
            btnExit2.UseVisualStyleBackColor = false;
            btnExit2.Click += btnExit2_Click;
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.BackColor = SystemColors.ButtonFace;
            btnAddRecipe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddRecipe.Location = new Point(17, 308);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(75, 23);
            btnAddRecipe.TabIndex = 25;
            btnAddRecipe.Text = "Add recipe";
            btnAddRecipe.UseVisualStyleBackColor = false;
            btnAddRecipe.Click += btnAddRecipe_Click;
            // 
            // btnSetRecipe
            // 
            btnSetRecipe.BackColor = SystemColors.ButtonFace;
            btnSetRecipe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSetRecipe.Location = new Point(229, 8);
            btnSetRecipe.Name = "btnSetRecipe";
            btnSetRecipe.Size = new Size(34, 23);
            btnSetRecipe.TabIndex = 26;
            btnSetRecipe.Text = "Set";
            btnSetRecipe.UseVisualStyleBackColor = false;
            btnSetRecipe.Click += btnSetRecipe_Click;
            // 
            // UpDownCalories
            // 
            UpDownCalories.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
            UpDownCalories.Location = new Point(212, 149);
            UpDownCalories.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            UpDownCalories.Name = "UpDownCalories";
            UpDownCalories.Size = new Size(42, 23);
            UpDownCalories.TabIndex = 24;
            // 
            // lblingreCalories
            // 
            lblingreCalories.AutoSize = true;
            lblingreCalories.Location = new Point(17, 151);
            lblingreCalories.Name = "lblingreCalories";
            lblingreCalories.Size = new Size(120, 15);
            lblingreCalories.TabIndex = 23;
            lblingreCalories.Text = "Enter calorie amount:";
            // 
            // txtIngreFoodGroup
            // 
            txtIngreFoodGroup.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIngreFoodGroup.Location = new Point(154, 94);
            txtIngreFoodGroup.Name = "txtIngreFoodGroup";
            txtIngreFoodGroup.Size = new Size(100, 23);
            txtIngreFoodGroup.TabIndex = 22;
            // 
            // lblingrFoodGroup
            // 
            lblingrFoodGroup.AutoSize = true;
            lblingrFoodGroup.Location = new Point(17, 94);
            lblingrFoodGroup.Name = "lblingrFoodGroup";
            lblingrFoodGroup.Size = new Size(100, 15);
            lblingrFoodGroup.TabIndex = 21;
            lblingrFoodGroup.Text = "Enter food group:";
            // 
            // btnClearIngre
            // 
            btnClearIngre.BackColor = SystemColors.ButtonFace;
            btnClearIngre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClearIngre.Location = new Point(17, 196);
            btnClearIngre.Name = "btnClearIngre";
            btnClearIngre.Size = new Size(75, 23);
            btnClearIngre.TabIndex = 20;
            btnClearIngre.Text = "Clear";
            btnClearIngre.UseVisualStyleBackColor = false;
            btnClearIngre.Click += btnClearIngre_Click;
            // 
            // btnClearStep
            // 
            btnClearStep.BackColor = SystemColors.ButtonFace;
            btnClearStep.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClearStep.Location = new Point(17, 286);
            btnClearStep.Name = "btnClearStep";
            btnClearStep.Size = new Size(75, 23);
            btnClearStep.TabIndex = 18;
            btnClearStep.Text = "Clear";
            btnClearStep.UseVisualStyleBackColor = false;
            btnClearStep.Click += btnClearStep_Click;
            // 
            // btnDisplayRecipe
            // 
            btnDisplayRecipe.BackColor = SystemColors.ButtonFace;
            btnDisplayRecipe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDisplayRecipe.Location = new Point(93, 308);
            btnDisplayRecipe.Name = "btnDisplayRecipe";
            btnDisplayRecipe.Size = new Size(104, 23);
            btnDisplayRecipe.TabIndex = 16;
            btnDisplayRecipe.Text = "DisplayRecipe";
            btnDisplayRecipe.UseVisualStyleBackColor = false;
            btnDisplayRecipe.Click += btnDisplayRecipe_Click;
            // 
            // btnAddStep
            // 
            btnAddStep.BackColor = SystemColors.ButtonFace;
            btnAddStep.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddStep.Location = new Point(93, 286);
            btnAddStep.Name = "btnAddStep";
            btnAddStep.Size = new Size(104, 23);
            btnAddStep.TabIndex = 15;
            btnAddStep.Text = "Add step";
            btnAddStep.UseVisualStyleBackColor = false;
            btnAddStep.Click += btnAddStep_Click;
            // 
            // btnAddIngre
            // 
            btnAddIngre.BackColor = SystemColors.ButtonFace;
            btnAddIngre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddIngre.Location = new Point(98, 196);
            btnAddIngre.Name = "btnAddIngre";
            btnAddIngre.Size = new Size(108, 23);
            btnAddIngre.TabIndex = 14;
            btnAddIngre.Text = "Add ingredient";
            btnAddIngre.UseVisualStyleBackColor = false;
            btnAddIngre.Click += btnAddIngre_Click;
            // 
            // txtStepDescription
            // 
            txtStepDescription.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStepDescription.Location = new Point(16, 260);
            txtStepDescription.Name = "txtStepDescription";
            txtStepDescription.Size = new Size(234, 23);
            txtStepDescription.TabIndex = 13;
            // 
            // lblStepDescription
            // 
            lblStepDescription.AutoSize = true;
            lblStepDescription.Location = new Point(15, 242);
            lblStepDescription.Name = "lblStepDescription";
            lblStepDescription.Size = new Size(124, 15);
            lblStepDescription.TabIndex = 12;
            lblStepDescription.Text = "Enter step description:";
            // 
            // UpDownQuantity
            // 
            UpDownQuantity.Location = new Point(212, 123);
            UpDownQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            UpDownQuantity.Name = "UpDownQuantity";
            UpDownQuantity.Size = new Size(42, 23);
            UpDownQuantity.TabIndex = 11;
            // 
            // txtUnitOfMesaure
            // 
            txtUnitOfMesaure.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnitOfMesaure.Location = new Point(188, 175);
            txtUnitOfMesaure.Name = "txtUnitOfMesaure";
            txtUnitOfMesaure.Size = new Size(66, 23);
            txtUnitOfMesaure.TabIndex = 10;
            // 
            // txtIngreName
            // 
            txtIngreName.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIngreName.Location = new Point(154, 65);
            txtIngreName.Name = "txtIngreName";
            txtIngreName.Size = new Size(100, 23);
            txtIngreName.TabIndex = 9;
            // 
            // lblIngreUnitofMeasure
            // 
            lblIngreUnitofMeasure.AutoSize = true;
            lblIngreUnitofMeasure.Location = new Point(17, 178);
            lblIngreUnitofMeasure.Name = "lblIngreUnitofMeasure";
            lblIngreUnitofMeasure.Size = new Size(151, 15);
            lblIngreUnitofMeasure.TabIndex = 8;
            lblIngreUnitofMeasure.Text = "Enter unit of measurement:";
            // 
            // lblIngreName
            // 
            lblIngreName.AutoSize = true;
            lblIngreName.Location = new Point(17, 65);
            lblIngreName.Name = "lblIngreName";
            lblIngreName.Size = new Size(127, 15);
            lblIngreName.TabIndex = 7;
            lblIngreName.Text = "Enter ingredient name:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(17, 123);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(160, 15);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Enter quantity of ingredients:";
            // 
            // UpDownSteps
            // 
            UpDownSteps.Location = new Point(212, 219);
            UpDownSteps.Name = "UpDownSteps";
            UpDownSteps.Size = new Size(42, 23);
            UpDownSteps.TabIndex = 5;
            // 
            // UpDownIngre
            // 
            UpDownIngre.Location = new Point(212, 36);
            UpDownIngre.Name = "UpDownIngre";
            UpDownIngre.Size = new Size(42, 23);
            UpDownIngre.TabIndex = 4;
            // 
            // lblStepNo
            // 
            lblStepNo.AutoSize = true;
            lblStepNo.Location = new Point(17, 221);
            lblStepNo.Name = "lblStepNo";
            lblStepNo.Size = new Size(126, 15);
            lblStepNo.TabIndex = 3;
            lblStepNo.Text = "Enter number of steps:";
            // 
            // lblIngeNo
            // 
            lblIngeNo.AutoSize = true;
            lblIngeNo.Location = new Point(15, 38);
            lblIngeNo.Name = "lblIngeNo";
            lblIngeNo.Size = new Size(158, 15);
            lblIngeNo.TabIndex = 2;
            lblIngeNo.Text = "Enter number of ingredients:";
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Location = new Point(15, 12);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(105, 15);
            lblRecipeName.TabIndex = 1;
            lblRecipeName.Text = "Enter recipe name:";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Font = new Font("Sitka Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRecipeName.Location = new Point(126, 8);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(100, 23);
            txtRecipeName.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(btnBackToAddRecipe);
            panel3.Controls.Add(lbDisplayIngreAndSteps);
            panel3.Controls.Add(btnChooseRecipe);
            panel3.Controls.Add(txtRecipeName2);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnScale);
            panel3.Location = new Point(606, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(266, 333);
            panel3.TabIndex = 1;
            // 
            // btnBackToAddRecipe
            // 
            btnBackToAddRecipe.BackColor = SystemColors.WindowFrame;
            btnBackToAddRecipe.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToAddRecipe.ForeColor = SystemColors.ButtonHighlight;
            btnBackToAddRecipe.Location = new Point(5, 8);
            btnBackToAddRecipe.Name = "btnBackToAddRecipe";
            btnBackToAddRecipe.Size = new Size(22, 29);
            btnBackToAddRecipe.TabIndex = 26;
            btnBackToAddRecipe.Text = "<";
            btnBackToAddRecipe.UseVisualStyleBackColor = false;
            btnBackToAddRecipe.Click += btnBackToAddRecipe_Click;
            // 
            // lbDisplayIngreAndSteps
            // 
            lbDisplayIngreAndSteps.AutoSize = true;
            lbDisplayIngreAndSteps.Font = new Font("Sitka Text", 9.749999F);
            lbDisplayIngreAndSteps.Location = new Point(33, 40);
            lbDisplayIngreAndSteps.Name = "lbDisplayIngreAndSteps";
            lbDisplayIngreAndSteps.Size = new Size(21, 19);
            lbDisplayIngreAndSteps.TabIndex = 25;
            lbDisplayIngreAndSteps.Text = "...";
            // 
            // btnChooseRecipe
            // 
            btnChooseRecipe.BackColor = SystemColors.ButtonFace;
            btnChooseRecipe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnChooseRecipe.Location = new Point(75, 300);
            btnChooseRecipe.Name = "btnChooseRecipe";
            btnChooseRecipe.Size = new Size(112, 23);
            btnChooseRecipe.TabIndex = 24;
            btnChooseRecipe.Text = "Choose a recipe";
            btnChooseRecipe.UseVisualStyleBackColor = false;
            btnChooseRecipe.Click += btnChooseRecipe_Click;
            // 
            // txtRecipeName2
            // 
            txtRecipeName2.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtRecipeName2.Location = new Point(33, 8);
            txtRecipeName2.Name = "txtRecipeName2";
            txtRecipeName2.Size = new Size(187, 29);
            txtRecipeName2.TabIndex = 23;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ButtonFace;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.Location = new Point(6, 300);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(63, 23);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnScale
            // 
            btnScale.BackColor = SystemColors.ButtonFace;
            btnScale.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScale.ForeColor = Color.Black;
            btnScale.Location = new Point(193, 300);
            btnScale.Name = "btnScale";
            btnScale.Size = new Size(61, 23);
            btnScale.TabIndex = 17;
            btnScale.Text = "Scale";
            btnScale.UseVisualStyleBackColor = false;
            btnScale.Click += btnScale_Click;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.infoPage31;
            panel4.Controls.Add(btnBackToViewRecipe2);
            panel4.Controls.Add(lblScaleBy);
            panel4.Controls.Add(btnTriple);
            panel4.Controls.Add(btnHalf);
            panel4.Controls.Add(btnDouble);
            panel4.Controls.Add(btnResetRecipe);
            panel4.Location = new Point(907, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(266, 333);
            panel4.TabIndex = 2;
            // 
            // btnBackToViewRecipe2
            // 
            btnBackToViewRecipe2.BackColor = SystemColors.WindowFrame;
            btnBackToViewRecipe2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToViewRecipe2.ForeColor = SystemColors.ButtonHighlight;
            btnBackToViewRecipe2.Location = new Point(12, 8);
            btnBackToViewRecipe2.Name = "btnBackToViewRecipe2";
            btnBackToViewRecipe2.Size = new Size(22, 29);
            btnBackToViewRecipe2.TabIndex = 28;
            btnBackToViewRecipe2.Text = "<";
            btnBackToViewRecipe2.UseVisualStyleBackColor = false;
            btnBackToViewRecipe2.Click += btnBackToViewRecipe2_Click;
            // 
            // lblScaleBy
            // 
            lblScaleBy.AutoSize = true;
            lblScaleBy.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblScaleBy.Location = new Point(88, 83);
            lblScaleBy.Name = "lblScaleBy";
            lblScaleBy.Size = new Size(79, 26);
            lblScaleBy.TabIndex = 21;
            lblScaleBy.Text = "Scale by:";
            // 
            // btnTriple
            // 
            btnTriple.BackColor = SystemColors.ButtonFace;
            btnTriple.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTriple.Location = new Point(188, 142);
            btnTriple.Name = "btnTriple";
            btnTriple.Size = new Size(75, 24);
            btnTriple.TabIndex = 22;
            btnTriple.Text = "Triple";
            btnTriple.UseVisualStyleBackColor = false;
            btnTriple.Click += btnTriple_Click;
            // 
            // btnHalf
            // 
            btnHalf.BackColor = SystemColors.ButtonFace;
            btnHalf.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHalf.Location = new Point(3, 142);
            btnHalf.Name = "btnHalf";
            btnHalf.Size = new Size(77, 24);
            btnHalf.TabIndex = 21;
            btnHalf.Text = "Half";
            btnHalf.UseVisualStyleBackColor = false;
            btnHalf.Click += btnHalf_Click;
            // 
            // btnDouble
            // 
            btnDouble.BackColor = SystemColors.ButtonFace;
            btnDouble.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDouble.Location = new Point(91, 142);
            btnDouble.Name = "btnDouble";
            btnDouble.Size = new Size(76, 24);
            btnDouble.TabIndex = 20;
            btnDouble.Text = "Double";
            btnDouble.UseVisualStyleBackColor = false;
            btnDouble.Click += btnDouble_Click;
            // 
            // btnResetRecipe
            // 
            btnResetRecipe.FlatStyle = FlatStyle.Popup;
            btnResetRecipe.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResetRecipe.Location = new Point(91, 248);
            btnResetRecipe.Name = "btnResetRecipe";
            btnResetRecipe.Size = new Size(76, 46);
            btnResetRecipe.TabIndex = 19;
            btnResetRecipe.Text = "Reset recipe";
            btnResetRecipe.UseVisualStyleBackColor = true;
            btnResetRecipe.Click += btnResetRecipe_Click;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.infoPage21;
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Controls.Add(btnExit5);
            panel5.Controls.Add(lblListOfAllRecipes);
            panel5.Controls.Add(btnBackToViewRecipe);
            panel5.Controls.Add(lbDisplaySelectedRecipe);
            panel5.Controls.Add(btnViewRecipe);
            panel5.Controls.Add(lbRecipeOptions);
            panel5.Location = new Point(27, 363);
            panel5.Name = "panel5";
            panel5.Size = new Size(266, 333);
            panel5.TabIndex = 1;
            // 
            // btnExit5
            // 
            btnExit5.BackColor = SystemColors.ButtonFace;
            btnExit5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit5.ForeColor = Color.Black;
            btnExit5.Location = new Point(202, 307);
            btnExit5.Name = "btnExit5";
            btnExit5.Size = new Size(61, 23);
            btnExit5.TabIndex = 30;
            btnExit5.Text = "Exit";
            btnExit5.UseVisualStyleBackColor = false;
            btnExit5.Click += btnExit5_Click_1;
            // 
            // lblListOfAllRecipes
            // 
            lblListOfAllRecipes.AutoSize = true;
            lblListOfAllRecipes.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblListOfAllRecipes.Location = new Point(31, 11);
            lblListOfAllRecipes.Name = "lblListOfAllRecipes";
            lblListOfAllRecipes.Size = new Size(125, 23);
            lblListOfAllRecipes.TabIndex = 28;
            lblListOfAllRecipes.Text = "List of all recipes:";
            // 
            // btnBackToViewRecipe
            // 
            btnBackToViewRecipe.BackColor = SystemColors.WindowFrame;
            btnBackToViewRecipe.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToViewRecipe.ForeColor = SystemColors.ButtonHighlight;
            btnBackToViewRecipe.Location = new Point(3, 18);
            btnBackToViewRecipe.Name = "btnBackToViewRecipe";
            btnBackToViewRecipe.Size = new Size(22, 29);
            btnBackToViewRecipe.TabIndex = 27;
            btnBackToViewRecipe.Text = "<";
            btnBackToViewRecipe.UseVisualStyleBackColor = false;
            btnBackToViewRecipe.Click += btnBackToViewRecipe_Click;
            // 
            // lbDisplaySelectedRecipe
            // 
            lbDisplaySelectedRecipe.AutoSize = true;
            lbDisplaySelectedRecipe.Font = new Font("Sitka Text", 9.749999F);
            lbDisplaySelectedRecipe.Location = new Point(31, 136);
            lbDisplaySelectedRecipe.Name = "lbDisplaySelectedRecipe";
            lbDisplaySelectedRecipe.Size = new Size(21, 19);
            lbDisplaySelectedRecipe.TabIndex = 26;
            lbDisplaySelectedRecipe.Text = "...";
            // 
            // btnViewRecipe
            // 
            btnViewRecipe.BackColor = SystemColors.ButtonFace;
            btnViewRecipe.Location = new Point(93, 104);
            btnViewRecipe.Name = "btnViewRecipe";
            btnViewRecipe.Size = new Size(82, 33);
            btnViewRecipe.TabIndex = 25;
            btnViewRecipe.Text = "View recipe";
            btnViewRecipe.UseVisualStyleBackColor = false;
            btnViewRecipe.Click += btnViewRecipe_Click;
            // 
            // lbRecipeOptions
            // 
            lbRecipeOptions.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbRecipeOptions.FormattingEnabled = true;
            lbRecipeOptions.ItemHeight = 19;
            lbRecipeOptions.Location = new Point(31, 37);
            lbRecipeOptions.Name = "lbRecipeOptions";
            lbRecipeOptions.Size = new Size(208, 61);
            lbRecipeOptions.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UpDownCalories).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownSteps).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpDownIngre).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Button btnGetStarted;
        private TextBox txtRecipeName;
        private Label lblRecipeName;
        private NumericUpDown UpDownSteps;
        private NumericUpDown UpDownIngre;
        private Label lblStepNo;
        private Label lblIngeNo;
        private Label lblIngreName;
        private Label lblQuantity;
        private TextBox txtStepDescription;
        private Label lblStepDescription;
        private NumericUpDown UpDownQuantity;
        private TextBox txtUnitOfMesaure;
        private TextBox txtIngreName;
        private Label lblIngreUnitofMeasure;
        private Button btnAddStep;
        private Button btnAddIngre;
        private Button btnDisplayRecipe;
        private Button btnClearIngre;
        private Button btnClearStep;
        private Button btnTriple;
        private Button btnHalf;
        private Button btnDouble;
        private Button btnResetRecipe;
        private Label lblScaleBy;
        private Button btnClear;
        private TextBox txtIngreFoodGroup;
        private Label lblingrFoodGroup;
        private NumericUpDown UpDownCalories;
        private Label lblingreCalories;
        private TextBox txtRecipeName2;
        private Button btnAddRecipe;
        private Button btnChooseRecipe;
        private ListBox lbRecipeOptions;
        private Button btnViewRecipe;
        private Button btnSetRecipe;
        private Label lbDisplayIngreAndSteps;
        private Label lbDisplaySelectedRecipe;
        private Button btnBackToAddRecipe;
        private Button btnBackToViewRecipe2;
        private Button btnBackToViewRecipe;
        private Label lblListOfAllRecipes;
        private Button btnScale;
        private Button btnExit5;
        private Button btnExit2;
    }
}
