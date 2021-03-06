namespace Site_Details
{
    public partial class Form1 : Form
    {
        #region Declaration

        //Declares a SiteDetails variable with no assigned value.
        private SiteDetails details;
        readonly private Color orange = Color.FromArgb(255, 162, 68);
        readonly private Color gray0 = Color.FromArgb(34, 34, 34);
        readonly private Color black = Color.Black;

        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Basic events
        private void Form1_OnLoad(object sender, EventArgs e)
        {
            /* 
             * Text to be displayed on the UI.
             * 
             * about & rules are stored as STRING arrays as a requirement by Windows Forms designer.
             * Each index counts as a new line, unlike other solutions that use "\n" as a break.
             * Lines can still be broken into several visible lines but only due to word wrapping.
             * If the UI is allowed to be extended horizontally, the word wrapping will no longer apply
             * and the whole string will be displayed as a single line.
             * 
             * rateArray is stored as a STRING array as well, but for a different reason.
             * Instead of having to make 5 different variables for essentially the same purpose,
             * only different targets, I combined them into an array instead for simplicity instead.
             */
            
            string[] about = new string[]
            {
                "YUMMY TEH FUD DA SAI' ay isang restaurant na nagawa ng mga estudyante ng " +
                "Bartholomew, sa pinagsama-samang kakaibang mga ideya ito ay nabuo. Burger " +
                "at fries ang kanilang pinaka produkto. Ang restaurant na ito ay isang ambisyon " +
                "na pilit tinutupad ng mga magkakagrupo. Sa tinagal ng panahon di malayong " +
                "ito'y maging patok din sa masa, ito ay proud pinoy brand na naglalayong " +
                "makarating ng ibat ibang bansa at makilala. Pinagmamalaki nila ang burger na " +
                "kung tawagin ay soo lit' dahil ito'y swak na swak sa bulsa ng masa ngunit kakaiba " +
                "ang sarap na naibibigay.",
                "",
                "Ang YUMMY TEH FUD DA SAI' din ang pwedeng maging " +
                "kauna-unahang brand na maitatatag dahil lamang sa proyekto nila noong " +
                "highschool. Hindi pa laganap ang aming branch ngunit patuloy na nagsisikap " +
                "upang makilala at tangkilikin ng kapawa kababayan natin ang produktong sariling " +
                "atin.",
                "",
                "Muli ito ang YUMMY TEH FUD DA SAI' order na!",
                "",
                "To place order kindly go to www.yummytehfuddasai.com.ph",
                "Landline number: 069 - 6969"
            };
            string[] rules = new string[]
            {
                "1. In banquets and formal gatherings, serve the host/hostess or the guest of honor first,",
                "   following a counterclockwise direction.",
                "" ,
                "2. In informal groups, serve the hostess first if she is known.",
                "   If the hostess is not identified, start with the most senior female in the group.",
                "" ,
                "3. In small, intimate groups, serve the female first, then the males.",
                "   Serve following a counterclockwise direction.",
                "" ,
                "4. The service of lunch or dinner follows this order: ",
                "\ta. As soon as the guest is seated,",
                "\t   fill the water glass three-fourths full with ice water.",
                "\t   Keep the water glass refilled continuously during the meal." ,
                "\tb. Serve chilled butter on a bread and butter plate and the appetizer at the ",
                "\t   center of the cover, if these are included in the menu.",
                "\tc. When the guest is through, remove the appetizer dish.",
                "\td. Serve the soup at the center of the cover.",
                "\te. Remove the soup plate or soup bowl after the guest is finished with the course.",
                "\tf. Serve the main dish or entree at the center of the cover in front of the guest.",
                "\tg. When the guest is through, remove main dishes and used flatware.",
                "\t   Leave the water glass, which is constantly replenished throughout the meal.",
                "\t   Leave the dessert implements, either teaspoon or dessert fork,",
                "\t   if they are set on the table.",
                "\th. If morsels of food or crumbs are on the table,",
                "\t   clear the table with the use of a napkin.",
                "\ti. Set the dessert implements if they have not yet been set.",
                "\tj. Serve the dessert at the center of the cover.",
                "\tk. Serve the beverage, if the diner prefers that it be served with the dessert.",
                "\t   Otherwise, beverage may be served after the dessert.",
                "" ,
                "5. For breakfast, the order of service begins with the fruit or fruit juice.",
                "   This is equivalent to soup and appetizer for lunch and dinner."
            };
            string[] rateArray =
                {
                    "graVity ha, grabe nga yan vebs!",
                    "why? why naman 4 lang? di na ba ako special sayo? Diba sabi mo, I'm only four you",
                    "bakit? threegered ka ba? Soury na, uwu",
                    "seryoso? hindi e2 biro ah, ayusin mo.",
                    "nag rate ka pa"
                };
            details = new(about, rules, rateArray);

            //Applies changes on startup.
            displayText.Lines = details.About;
            opt5.Text = details.Rate[0];
            opt4.Text = details.Rate[1];
            opt3.Text = details.Rate[2];
            opt2.Text = details.Rate[3];
            opt1.Text = details.Rate[4];
        }

        //When aboutButton is clicked...
        private void AboutBtn_OnClick(object sender, EventArgs e)
        {
            //Make the text display visible.
            TabVisibility(true);

            //Set the text to value of details.About.
            displayText.Lines = details.About;

            //Change button colors.
            aboutButton.ForeColor = black;
            aboutButton.BackColor = orange;
            rulesButton.ForeColor = orange;
            rulesButton.BackColor = gray0;
            rateButton.ForeColor = orange;
            rateButton.BackColor = gray0;
        }

        //When rulesButton is clicked...
        private void RulesBtn_OnClick(object sender, EventArgs e)
        {
            //Make the text display visible.
            TabVisibility(true);

            //Set the text to value of details.Rules.
            displayText.Lines = details.Rules;

            //Change button colors.
            aboutButton.ForeColor = orange;
            aboutButton.BackColor = gray0;
            rulesButton.ForeColor= black;
            rulesButton.BackColor = orange;
            rateButton.ForeColor= orange;
            rateButton.BackColor = gray0;
        }

        //When rateButton is clicked...
        private void RateBtn_OnClick(object sender, EventArgs e)
        {
            //Make the text display invisible.
            //Subsequently, this also makes the buttons visible.
            TabVisibility(false);

            //Change button colors.
            aboutButton.ForeColor = orange;
            aboutButton.BackColor = gray0;
            rulesButton.ForeColor = orange;
            rulesButton.BackColor = gray0;
            rateButton.ForeColor = black;
            rateButton.BackColor = orange;
        }
        #endregion

        #region Rate button events
        //These will activate when their respective buttons are clicked.
        private void Rate5Btn_OnClick(object sender, EventArgs e)
        {
            ActivateRating(5);
        }

        private void Rate4Btn_OnClick(object sender, EventArgs e)
        {
            ActivateRating(4);
        }

        private void Rate3Btn_OnClick(object sender, EventArgs e)
        {
            ActivateRating(3);
        }

        private void Rate2Btn_OnClick(object sender, EventArgs e)
        {
            ActivateRating(2);
        }

        private void Rate1Btn_OnClick(object sender, EventArgs e)
        {
            ActivateRating(1);
        }

        //When the submit button is clicked...
        private void SubmitBtn_OnClick(object sender, EventArgs e)
        {
            Color c40 = Color.FromArgb(40, 40, 40);

            //Display a popup message.
            MessageBox.Show("Thanks for rating!");

            //Make these elements unclickable.
            submitButton.Enabled = false;
            opt5.Enabled = false;
            opt4.Enabled = false;
            opt3.Enabled = false;
            opt2.Enabled = false;
            opt1.Enabled = false;

            //Change these elements' background colors to #444 gray.
            opt5.BackColor = c40;
            opt4.BackColor = c40;
            opt3.BackColor = c40;
            opt2.BackColor = c40;
            opt1.BackColor = c40;
            submitButton.BackColor = c40;

            //Change the rateUsLabel text to...
            rateUsLabel.Text = "Thanks for rating!";

            //Simulate About button click.
            AboutBtn_OnClick(sender, e);
        }
        #endregion

        #region Shortcut functions
        /// <summary>
        /// Toggles the visibility of tabs. Set to TRUE to set the text box visible. Set to FALSE to set the rating visible.
        /// </summary>
        /// <param name="opt"></param>
        void TabVisibility(bool opt)
        {
            opt = !opt; //Reversing value for simplicity.

            //Make the individual elements visible or invisible.
            displayText.Visible = !opt;
            opt5.Visible = opt;
            opt4.Visible = opt;
            opt3.Visible = opt;
            opt2.Visible = opt;
            opt1.Visible = opt;
            opt5Label.Visible = opt;
            opt4Label.Visible = opt;
            opt3Label.Visible = opt;
            opt2Label.Visible = opt;
            opt1Label.Visible = opt;
            rateUsLabel.Visible = opt;
            submitButton.Visible = opt;
        }

        
        void ActivateRating(int num)
        {
            //Make the submit button clickable.
            submitButton.Enabled = true;

            Color orange = Color.FromArgb(255, 128, 0);
            Color gray1 = Color.FromArgb(64, 64, 64);
            Color gray2 = Color.FromArgb(40, 40, 40);
            Color gray3 = Color.FromArgb(34, 34, 34);

            //5 Stars
            //If the number is NOT 5, change the colors to gray 1 and 3 respectively.
            //Else (if the number IS 5), change the colors to orange and gray 2 respectively.
            if (num != 5)
            {
                opt5Label.ForeColor = gray1;
                opt5.BackColor = gray3;
            } else
			{
                opt5Label.ForeColor = orange;
                opt5.BackColor = gray2;
			}

            //4 Stars
            if (num != 4)
			{
                opt4Label.ForeColor = gray1;
                opt4.BackColor= gray3;
			} else
			{
                opt4Label.ForeColor = orange;
                opt4.BackColor = gray2;
            }

            //3 stars
            if (num != 3)
            {
                opt3Label.ForeColor = gray1;
                opt3.BackColor = gray3;
            }
            else
            {
                opt3Label.ForeColor = orange;
                opt3.BackColor = gray2;
            }

            //2 stars
            if (num != 2)
            {
                opt2Label.ForeColor = gray1;
                opt2.BackColor = gray3;
            }
            else
            {
                opt2Label.ForeColor = orange;
                opt2.BackColor = gray2;
            }

            //1 star
            if (num != 1)
            {
                opt1Label.ForeColor = gray1;
                opt1.BackColor = gray3;
            }
            else
            {
                opt1Label.ForeColor = orange;
                opt1.BackColor = gray2;
            }
        }
		#endregion
	}

	/// <summary>
	/// An object that holds the texts to be displayed in the UI.
	/// </summary>
	public class SiteDetails
    {
        public SiteDetails(string[] aboutTexts, string[] rulesTexts, string[] rateTexts)
        {
            this.About = aboutTexts;
            this.Rules = rulesTexts;
            this.Rate = rateTexts;
        }

        //Declares the object attributes, along with their getters and setters.
        public string[] About { get; set; }

        public string[] Rules { get; set; }

        public string[] Rate { get; set; }
    }
}