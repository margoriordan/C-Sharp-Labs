using Microsoft.VisualBasic.Devices;

namespace Exercise_5
{
    public partial class Playfair : Form
    {
        public Playfair()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            input_txt.Clear();
            output_txt.Clear();
            keyword_txt.Clear();
        }

        private void transBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    //prepare keyword and remaining letters for matrix
                    string keyword = keyword_txt.Text;
                    string alphabet = "abcdefghiklmnopqrstuvwxyz";
                    char[] keyPrepared = prepareKeyword(keyword, alphabet);

                    //load matrix
                    char[,] matrix = new char[5, 5];
                    matrix = prepareMatrix(keyPrepared);

                    //read and prepare input for encryption
                    string rawInput = input_txt.Text;
                    string[] rawInputArray = encryptPrepare(rawInput);

                    //create and load list of coordinates of letters according to matrix
                    List<int[]> coordinates = findCoordinates(rawInputArray, matrix);

                    //encrypt input according to assignment playfair rules
                    string encryptedInput = finalizeEncryption(rawInput, matrix, coordinates);

                    //display text
                    output_txt.Text = encryptedInput;
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }

        }

        public bool IsValidData()
        {
            bool success = true;
            string errorMsg = "";

            //validate text boxes
            errorMsg += IsPresent(keyword_txt.Text, "Keyword");
            errorMsg += IsPresent(input_txt.Text, "Input");
            
            if (errorMsg != "")
            {
                success = false;
                MessageBox.Show(errorMsg, "Entry Error");
            }
            return success;
        }
        public static string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg = name + " cannot be left empty.\n";
            }
            return msg;
        }

        public static char[] prepareKeyword(string phrase, string letters)
        {
            //remove letter j and replace with letter i
            phrase = phrase.Replace('j', 'i');
            string keywordAlpha = phrase + letters;
            keywordAlpha = keywordAlpha.ToLower();

            //remove duplicates and convert to array
            char[] keyPrepared = keywordAlpha.Distinct().ToArray();

            return keyPrepared;


        }

        public static char[,] prepareMatrix(char[] keyPrepared)
        {
            //place prepared key and remaining letters into 5x5 matrix
            int keyIndex = 0;
            char[,] matrix = new char[5, 5];

            for (int row = 0; row < 5; row++)
            {
                for (int column = 0; column < 5; column++)
                {
                    if (keyIndex < keyPrepared.Length)
                    {
                        matrix[row, column] = keyPrepared[keyIndex];
                        keyIndex++;
                    }
                }
            }
            return matrix;
        }

        public static string[] encryptPrepare(string input)
        {
            //prepare input for encryption
            input = input.ToLower();
            string[] inputArray = input.Split();
            return inputArray;
        }

        public static List<int[]> findCoordinates(string[] inputArray, char[,] grid)
        {
            List<int[]> coordinates = new List<int[]>();

            foreach (string word in inputArray)
            {
                foreach (char c in word)
                {
                    for (int row = 0; row < 5; row++)
                    {
                        for (int column = 0; column < 5; column++)
                        {
                            if (grid[row, column] == c)
                            {
                                coordinates.Add(new int[] { row, column });
                            }
                        }
                    }
                }
            }
            return coordinates;

        }

        public static string finalizeEncryption(string input, char[,] grid, List<int[]> coordinates)
        {
            //add back spaces & punctuation + encrypt by switching coordinates
            int inputIndex = 0;
            string encryptedInput = "";

            foreach (var coordinate in coordinates)
            {
                char character = grid[coordinate[1], coordinate[0]];

                if (inputIndex < input.Length && char.IsWhiteSpace(input[inputIndex]))
                {
                    encryptedInput += " ";
                    inputIndex++;
                }
                if (inputIndex < input.Length && char.IsPunctuation(input[inputIndex]))
                {
                    encryptedInput += input[inputIndex];
                    inputIndex++;
                }
                if (inputIndex < input.Length && char.IsDigit(input[inputIndex]))
                {
                    encryptedInput += input[inputIndex];
                    inputIndex++;
                }
               
                encryptedInput += character;
                inputIndex++;
                
                

            }
            return encryptedInput;
        }
    }

}