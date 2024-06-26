using System.Security.Cryptography;

namespace ProgPOE
{
    public partial class Form1 : Form
    {
        public Recipes recipes;
        public Recipes recentRecipe;
        public Steps steps;
        public Ingredients ingredients;

        public SortedList<string, Recipes> SortedRecipesList; //(user1153537, 2024)
        public List<Ingredients> IngredientsList;
        public List<Steps> StepsList;

        //  public SortedList<string, Recipes> FilteredRecipesList;

        public Form1()
        {
            SortedRecipesList = new SortedList<string, Recipes>(); //initializing Sorted Recipes List to SortedRecipes
                                                                   //   FilteredRecipesList = new SortedList<string, Recipes>();

            InitializeComponent();
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            //    panel6.Visible = false;

            panel1.Location = new Point(0, 0);
            panel2.Location = new Point(0, 0);
            panel3.Location = new Point(0, 0);
            panel4.Location = new Point(0, 0);
            panel5.Location = new Point(0, 0);
            //    panel6.Location = new Point(0, 0);

            lblStepNo.Visible = false;
            UpDownSteps.Visible = false;
            lblStepDescription.Visible = false;
            txtStepDescription.Visible = false;
            btnClearStep.Visible = false;
            btnAddStep.Visible = false;
            btnDisplayRecipe.Visible = false;
            btnAddRecipe.Visible = false;

        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;

            lblRecipeName.Visible = true;
            txtRecipeName.Visible = true;
            lblIngeNo.Visible = true;
            UpDownIngre.Visible = true;
            lblIngreName.Visible = true;
            txtIngreName.Visible = true;
            lblQuantity.Visible = true;
            UpDownQuantity.Visible = true;
            lblIngreUnitofMeasure.Visible = true;
            txtUnitOfMesaure.Visible = true;
        }

        private void btnClearIngre_Click(object sender, EventArgs e)
        {
            txtIngreName.Text = "";
            txtUnitOfMesaure.Text = "";
            txtIngreFoodGroup.Text = "";
            UpDownQuantity.Value = 0;
            UpDownCalories.Value = 0;
        }

        private void btnAddIngre_Click(object sender, EventArgs e)
        {

            string ingredientName = txtIngreName.Text;
            double quantity = Convert.ToDouble(UpDownQuantity.Value);
            string unitOfMeasurement = txtUnitOfMesaure.Text;
            string foodGroup = txtIngreFoodGroup.Text;
            double calories = Convert.ToDouble(UpDownCalories.Value);
            string recipeName = txtRecipeName.Text;

            if (string.IsNullOrWhiteSpace(recipeName) || string.IsNullOrWhiteSpace(ingredientName) || string.IsNullOrWhiteSpace(unitOfMeasurement) || string.IsNullOrWhiteSpace(foodGroup) || quantity == 0.0 || calories == 0.0)
            {
                MessageBox.Show("You left a field blank. Please enter all fields."); //error handeling to check for empty fields
            }
            else
            {
                Ingredients ingredient = new Ingredients(ingredientName, quantity, unitOfMeasurement, foodGroup, calories, recipeName); //initializing the Ingredient class and calling the constructor method with corresponding parameters
                recentRecipe.AddIngredient(ingredient);
                recentRecipe.ExceededCalories += OnExceededCalories;

                lblStepNo.Visible = true;
                UpDownSteps.Visible = true;
                lblStepDescription.Visible = true;
                txtStepDescription.Visible = true;
                btnClearStep.Visible = true;
                btnAddStep.Visible = true;
                btnDisplayRecipe.Visible = true;
                btnAddRecipe.Visible = true;

            }
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            SortedRecipesList.Add(recentRecipe.RecipeName, recentRecipe); //adds the recipe name (string) and the recipe
            txtRecipeName2.Text = recentRecipe.RecipeName;
            // recentRecipe.ExceededCalories += OnExceededCalories;

        }

        private void btnClearStep_Click(object sender, EventArgs e)
        {
            txtStepDescription.Text = "";
        }

        private void btnAddStep_Click(object sender, EventArgs e)
        {
            string stepDescription = txtStepDescription.Text;
            if (string.IsNullOrWhiteSpace(stepDescription)) //error handeling to check for empty fields
            {
                MessageBox.Show("You left a field blank. Please enter all fields.");
            }
            else
            {
                Steps step = new Steps(stepDescription); //initializing variable 'step' to class "Step" taking in the string 'stepDescription'

                recentRecipe.AddStep(step);

            }
        }

        private void btnDisplayRecipe_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;

            lbDisplayIngreAndSteps.Text = recentRecipe.PrintRecipe();
        }

        private void btnScale_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;

            lblScaleBy.Visible = true;
            btnHalf.Visible = true;
            btnDouble.Visible = true;
            btnTriple.Visible = true;
        }

        private void btnHalf_Click(object sender, EventArgs e)
        {
            double scaleFactor = 0.5;
            recentRecipe.ScalingTheRecipe(scaleFactor);
            lbDisplayIngreAndSteps.Text = recentRecipe.PrintRecipe();
            panel4.Visible = false;
            panel3.Visible = true;

        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            double scaleFactor = 2;
            recentRecipe.ScalingTheRecipe(scaleFactor);
            lbDisplayIngreAndSteps.Text = recentRecipe.PrintRecipe();
            panel4.Visible = false;
            panel3.Visible = true;

        }

        private void btnTriple_Click(object sender, EventArgs e)
        {
            double scaleFactor = 3;
            recentRecipe.ScalingTheRecipe(scaleFactor);
            lbDisplayIngreAndSteps.Text = recentRecipe.PrintRecipe();
            panel4.Visible = false;
            panel3.Visible = true;


        }

        private void btnResetRecipe_Click(object sender, EventArgs e)
        {
            recentRecipe.ResetRecipe();
            lbDisplayIngreAndSteps.Text = recentRecipe.PrintRecipe();
            panel4.Visible = false;
            panel3.Visible = true;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbDisplayIngreAndSteps.Text = "";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = true;

        }

        private void btnChooseRecipe_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel5.Visible = true;
            lbRecipeOptions.Text = "";

            int index = 1;
            foreach (var recipeName in SortedRecipesList.Keys) //this is meant to show a number next to each recipeName called from the SortedList
            {
                lbRecipeOptions.Items.Add(index + ". " + recipeName);
                index++;
            }
        }

        private void btnViewRecipe_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbRecipeOptions.SelectedIndex; //takes in the int of the up down scroll selection

            if (selectedIndex == -1) //error handeling to check whether index selection is within bounds
            {
                MessageBox.Show("Recipe number out of range. Please re-select");
                return;
            }
            else
            {
                lbDisplaySelectedRecipe.Text = "";

                Recipes selectedRecipe = SortedRecipesList[lbRecipeOptions.SelectedItem.ToString().Substring(lbRecipeOptions.SelectedItem.ToString().IndexOf('.') + 2)]; //this variable stores the recipe name by extracting the everything after the ". " and executes this when the recipe name is selected
                lbDisplaySelectedRecipe.Text = "Recipe:" + selectedRecipe.RecipeName + "\n";
                lbDisplaySelectedRecipe.Text += selectedRecipe.PrintRecipe();
            }
        }

        private void OnExceededCalories(string recipeName, double totalCalories)//(Vidya Vrat Agarwal, 2023)
        {
            MessageBox.Show("Recipe exceeds the 300kcal limit!\n" + recipeName + "' contains " + totalCalories + "kcal.", "CALORIE WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSetRecipe_Click(object sender, EventArgs e)
        {
            recentRecipe = new Recipes(txtRecipeName.Text); //assigns the recipe entered into the 'recentRecipe' variable

        }
        private void btnBackToAddRecipe_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = true;
        }

        private void btnBackToViewRecipe_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel3.Visible = true;
        }

        private void btnBackToViewRecipe2_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel3.Visible = true;
        }

        //private void btnBackToPanel5_Click(object sender, EventArgs e)
        //{
        //    panel6.Visible = false;
        //    panel5.Visible = true;
        //}

        private void btnExit2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void btnExit5_Click_1(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel1.Visible = true;
        }

        private void lbRecipeOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //private void cbFilterOptions_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cbFilterOptions.Text == "Ingredient")
        //    {
        //     //   lbDisplayIngreAndSteps.Text = FilteredRecipesList.PrintRecipe();
        //    }
        //    else if(cbFilterOptions.Text == "Food group")
        //    {
        //     //   lbDisplayIngreAndSteps.Text = FilteredRecipesList.PrintRecipe();
        //    }
        //    else if (cbFilterOptions.Text == "Calories")
        //    {
        //     //   lbDisplayIngreAndSteps.Text = FilteredRecipesList.PrintRecipe();
        //    }
        //}

        //public SortedList<string,Recipes> filteredIngredients()
        //{
        //    string searchWord = txtSearchbox.Text;
        //    string filteredWord = searchWord.Trim();

        //    if (SortedRecipesList.Contains(ingredients) 
        //    {
        //      //want to check if the filterWord matches the ingredient in the stored SortedRecipesList
        //    }

        //   // FilteredRecipesList must equal all the recipes that have been filtered
        //    return FilteredRecipesList;
        //}

        //public SortedList<string, Recipes> filteredFoodGroups()
        //{
        //    string filterWord = txtSearchbox.Text;

        //    if (filterWord.Trim)
        //    {
        //        //want to check if the filterWord matches the food group in the stored SortedRecipesList
        //    }

        //    // FilteredRecipesList must equal all the recipes that have been filtered
        //    return FilteredRecipesList;
        //}

        //public SortedList<string, Recipes> filteredCalories()
        //{
        //    string filterWord = txtSearchbox.Text;

        //    if (filterWord.Trim())
        //    {
        //        //want to check if the filterWord matches the calories or less in the stored SortedRecipesList
        //    }

        //    // FilteredRecipesList must equal all the recipes that have been filtered
        //    return FilteredRecipesList;
        //}
    }
}
//Referencing:
//
//GitHub. (2024). OOP2024/OOP2024 at master · rece212/OOP2024. [online] Available at: https://github.com/rece212/OOP2024/tree/master/OOP2024 [Accessed 30 May 2024].
//
//Vidya Vrat Agarwal (2023). Mastering Delegates and Events In C# .NET. [online] C-sharpcorner.com. Available at: https://www.c-sharpcorner.com/UploadFile/84c85b/delegates-and-events-C-Sharp-net/ [Accessed 30 May 2024].
//
//user1153537 (2024). Can you call List(T) placed inside another method, how to initiate List(T)? [online] Stack Overflow. Available at: https://stackoverflow.com/questions/8892305/can-you-call-listt-placed-inside-another-method-how-to-initiate-listt [Accessed 30 May 2024].
//
//Duggal, N. (2021). Introduction to List in C#. [online] Simplilearn.com. Available at: https://www.simplilearn.com/tutorials/asp-dot-net-tutorial/c-sharp-list [Accessed 30 May 2024].‌