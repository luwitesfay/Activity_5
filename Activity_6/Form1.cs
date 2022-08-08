namespace Activity_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Button click that upload a file through file upload
        private void button1_Click(object sender, EventArgs e)
        {
            //a method to one the file from the user locals
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //int varaibled find and set to the value 0 which later will be replace with the value retrived from the code
                int longestwordcalc = 0;
                int longestWordValue = 0;
                int mostVowelcalc = 0;
                int MostVowelsValue = 0;

                //a file redaing fromthe file and converting to all lowercase
                FileContentDisplay.Text = System.IO.File.ReadAllText(openFileDialog1.FileName).ToLower();

                //string spliet with a ' " in between each strings
                string[] wordArrayList = FileContentDisplay.Text.Split(' ');//split string with blank seperator

                //First word finder with arround list 0
                firstWord.Text = wordArrayList[0];

                //Last word finer with the maximum legth of array subtracted by 1
                lastWord.Text = wordArrayList[wordArrayList.Length - 1];

                //For loop that intialize the value of the arry and find the word with the maximum letters 
                for (int i = 0; i < wordArrayList.Length; i++)
                {
                    if (longestwordcalc < wordArrayList[i].Length)
                    {
                        longestwordcalc = wordArrayList[i].Length;
                        longestWordValue = i;
                    }
                   
                }
                LongestWord.Text = wordArrayList[longestWordValue];


                //For loop that intialize the value of the arry and find the word with the most vowels 
                for (int i = 0; i < wordArrayList.Length; i++)
                {
                    if (mostVowelcalc < VowelCharnum(wordArrayList[i]))
                    {
                        mostVowelcalc = VowelCharnum(wordArrayList[i]);
                        MostVowelsValue = i;
                    }
                }
                textBox5.Text = wordArrayList[MostVowelsValue];


                //here is the file write which gets the data and diplayed in the webiste in the assigned textboxes
                System.IO.File.WriteAllText(@"results.txt", FileContentDisplay.Text
                + firstWord.Text + lastWord.Text + LongestWord.Text + textBox5);

            }

        }
        //int variable that intalise what the vowel latters are and calculates the word with the most vowels and return it to the preious class
        //whoch then will be calculated displayed
        private int VowelCharnum(string sentence)//function for vowel count here
        {
            //intilizing the int varivle
            int vowelCharnum = 0;

            //For llop that cound the word with the most vowels by seeting the word with the most vowels
            for (int i = 0; i < sentence.Length; i++)
            {
                if ((sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u') || (sentence[i] == 'A' || sentence[i] == 'E' || sentence[i] ==
                'I' || sentence[i] == 'O' || sentence[i] == 'U'))
                {
                    vowelCharnum++;
                }

            }
            //a retun value that retuen the value of the vowel
            return vowelCharnum;
        }


        private void FileContentDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}