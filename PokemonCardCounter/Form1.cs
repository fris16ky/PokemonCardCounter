namespace PokemonCardCounter
{

    using System;
    using System.Drawing;
    using System.IO;
    using System.Security;
    using System.Windows.Forms;

    /* Only future updates would be probably making the code more efficient (instead of having two fields for each generation (total and bool), updating the comments,
    and maybe formatting the output better. Maybe some visuals with my favorite Pokemon from each generation? Now THAT'd be fun!!!
    Or, even better (?), add my favorite pulled card/just a dope card from each Generation? That would be fun as fuck, although the rectangles the images
    will be may make it awkward 
    */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Next up: Formatting is up next. Probably put text boxes above the images, make it look nice and pretty big text. Will need to add some text boxes
        //and do some maneuvering with where to send the text. Might want a summary (the all-together) somewhere. Maybe bottom right for now? ton of space since
        //Only 9 generations... for now :)



        //A few notes about this code. The way I noted the cards is not the most efficient. Mainly for Tag Team cards, if I have an Umbreon & Darkrai Tag Team GX, 
        //I wrote down 1 for Umbreon, and 1 for Darkrai (2 cards when it should just be one), so there will be very minor discrepancies in the totals. 
        //BUT, this also doesn't count all of my trainer cards, since there's really not a good way of writing those down without being either SUPER specific
        //or very generic, so I'm missing out on a MASSIVE chunk of cards due to that as well. All in good fun though!

        //As another note, I went through and manually cleared the file, but depending on how well I remember, I might 'break it' again. I.e. Lechonk (10) won't count as anything
        //I've tried to manually adjust all to be Lechonk (10 Normal), which fixes the issue. Also, any other numbers used change the values. i.e. Regigias Lv. 56 Holo, 
        //or Misty's Starmie CGC 9, or Pikachu and Gen 9 Starters Art Rare. I went through to remove all of those, but I always could have missed a few. 

        private void openFileButton_Click(object sender, EventArgs e)
        {
            //When the button is clicked, show the Dialog box with the openFile button

            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Pokemon Collection.rtf",
                Filter = "Text Files (*.txt;*.rtf)|*.txt;*.rtf",
                Title = "Open Text File"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialog1.FileName;
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        //Starting to read the file inputted, initialize important values
                        int total = 0;
                        int totalGen1 = 0, totalGen2 = 0, totalGen3 = 0, totalGen4 = 0, totalGen5 = 0, totalGen6 = 0, totalGen7 = 0, totalGen8 = 0, totalGen9 = 0;
                        bool reachedGen2 = false, reachedGen3 = false, reachedGen4 = false, reachedGen5 = false, reachedGen6 = false, reachedGen7 = false,
                            reachedGen8 = false, reachedGen9 = false, reachedEnd = false;


                        //4/12 starting this code: going to try to make this work to give a count for each Generation. Might go bare bones for now, 
                        //streamline/make it better in the future (aka I'm doing it manually - totalGen2, reachedGen3 etc. 
                        //There is definitely a way to make it more efficient. i.e. reachedNextGen instead (but for this, skip if it's Gen 8.5, include that in Gen 8

                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            //While there's still lines to read, check if we've reached "Generation 2"
                            if (line.Contains("Generation 2: "))
                            {
                                reachedGen2 = true;
                                continue;
                            }
                            else if (line.Contains("Generation 3: "))
                            {
                                reachedGen3 = true;
                                continue;
                            }
                            else if (line.Contains("Generation 4: "))
                            {
                                reachedGen4 = true;
                                continue;
                            }
                            else if (line.Contains("Generation 5: "))
                            {
                                reachedGen5 = true;
                                continue;
                            }
                            else if (line.Contains("Generation 6: "))
                            {
                                reachedGen6 = true;
                                continue;
                            }
                            else if (line.Contains("Generation 7: "))
                            {
                                reachedGen7 = true;
                                continue;
                            }
                            else if (line.Contains("Generation 8: "))
                            {
                                reachedGen8 = true;
                                continue;
                            }
                            else if (line.Contains("Generation 9: "))
                            {
                                reachedGen9 = true;
                                continue;
                            }
                            else if (line.Contains("Pokemon Trainer Cards: "))
                            {
                                //We are done with every generation, only things that remain are loosely related Pokemon-based Trainer Cards
                                //i.e. Mega Pokemon items, Fossils. 
                                reachedEnd = true;
                                continue; //still continue to sum up cards
                            }
                            else if (line.Contains("Generation"))
                            {
                                //If it sees "Generation", don't count that number - separated by Generations like "Generation 1" and such
                                //There is also one card that is a GenerationS Holo (note the s); don't want to skip that line

                                //As of 4/12, I don't think this is necessary? Will go back through the code eventually
                                continue;
                            }

                            //Split the line into words (NOTE: Porygon2 will not count as '2', nor will Misty's Starmie CGC9.5 as '9.5', since it tests the whole word as an Int)
                            string[] words = line.Split(' ');
                            for (int i = 0; i < words.Length; i++)
                            {
                                if (words[i].StartsWith("("))
                                {
                                    //For every first value (i.e. Voltorb (10 normal), splitting by Spaces would mean it tries to see if (10 is a number. 
                                    //So, we remove the ( to ensure that the first values are counted!
                                    words[i] = words[i].Substring(1);
                                }
                            }

                            //Iterate over each word in the line
                            foreach (string word in words)
                            {
                                // Try parsing each word as an integer
                                if (int.TryParse(word, out int number))
                                {
                                    //If the parsing succeeds, it's an integer. Add to the total(s)
                                    if (!reachedGen2)
                                    {
                                        //Sum to keep track of the Gen1 totals while the boolean is false
                                        totalGen1 += number;
                                    }
                                    else if (reachedGen2 && !reachedGen3)
                                    {
                                        //Currently on Gen 2 but not at Gen 3 yet
                                        totalGen2 += number;

                                        //Note, I manually checked Gen 2 to see if it works and I got 1 off (1133, code got 1132). So, I think it works! Assuming I overcounted
                                    }
                                    else if (reachedGen3 && !reachedGen4)
                                    {
                                        totalGen3 += number;
                                    }
                                    else if (reachedGen4 && !reachedGen5)
                                    {
                                        totalGen4 += number;
                                    }
                                    else if (reachedGen5 && !reachedGen6)
                                    {
                                        totalGen5 += number;
                                    }
                                    else if (reachedGen6 && !reachedGen7)
                                    {
                                        totalGen6 += number;
                                    }
                                    else if (reachedGen7 && !reachedGen8)
                                    {
                                        totalGen7 += number;
                                    }
                                    else if (reachedGen8 && !reachedGen9)
                                    {
                                        totalGen8 += number;
                                    }
                                    else if (reachedGen9 && !reachedEnd)
                                    {
                                        totalGen9 += number;
                                        //Manually checked that gen 9 is correct (2 off from my rushed manual calcs), and that it doesn't include the sporadic trainer cards.
                                    }
                                    //Sum regardless
                                    total += number;

                                }
                            }
                        }
                        // Display the sums
                        MessageBox.Show($"Excluding trainer cards, I have {total} Pokemon Cards!\n" +
                                        $"Of these, I have {totalGen1} cards from Generation 1,\n" +
                                        $"{totalGen2} cards from Generation 2,\n" +
                                        $"{totalGen3} cards from Generation 3,\n" +
                                        $"{totalGen4} cards from Generation 4,\n" +
                                        $"{totalGen5} cards from Generation 5,\n" +
                                        $"{totalGen6} cards from Generation 6,\n" +
                                        $"{totalGen7} cards from Generation 7,\n" +
                                        $"{totalGen8} cards from Generation 8,\n" +
                                        $"and {totalGen9} cards from Generation 9!\n");
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security Error.\n\nError Message: {ex.Message}\n\n" +
                                    $"Details:\n\n{ex.StackTrace}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while processing the file.\n\nError Message: {ex.Message}\n\n" +
                                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    }
}
