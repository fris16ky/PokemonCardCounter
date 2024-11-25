namespace PokemonCardCounter
{

    using System;
    using System.Drawing;
    using System.IO;
    using System.Security;
    using System.Windows.Forms;

    /* Only future updates would be probably making the code more efficient (instead of having two fields for each generation (total and bool), maybe add a fancy way
    of displaying the info (i.e. transition). 
    */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //As soon as the code starts, make the already-in-place designs invisible until a file is uploaded
            gen1Card.Visible = false;
            gen2Card.Visible = false;
            gen3Card.Visible = false;
            gen4Card.Visible = false;
            gen5Card.Visible = false;
            gen6Card.Visible = false;
            gen7Card.Visible = false;
            gen8Card.Visible = false;
            gen9Card.Visible = false;
            textGen1.Visible = false;
            textGen2.Visible = false;
            textGen3.Visible = false;
            textGen4.Visible = false;
            textGen5.Visible = false;
            textGen6.Visible = false;
            textGen7.Visible = false;
            textGen8.Visible = false;
            textGen9.Visible = false;
            welcomeText.Visible = false;
            totalText.Visible = false;
        }

        /*A few notes about this code. The way I noted the cards is not the most efficient. Mainly for Tag Team cards, if I have an Umbreon & Darkrai Tag Team GX, 
        I wrote down 1 for Umbreon, and 1 for Darkrai (2 cards when it should just be one), so there will be very minor discrepancies in the totals. 
        BUT, this also doesn't count all of my trainer cards, since there's really not a good way of writing those down without being either SUPER specific
        or very generic, so I'm missing out on a MASSIVE chunk of cards due to that as well. All in good fun though!

        As another note, I went through and manually cleared the file, but depending on how well I remember, I might 'break it' again. I.e. Lechonk (10) won't count as anything
        I've tried to manually adjust all to be Lechonk (10 Normal), which fixes the issue. Also, any other numbers used change the values. i.e. Regigias Lv. 56 Holo, 
        or Misty's Starmie CGC 9, or Pikachu and Gen 9 Starters Art Rare. I went through to remove all of those, but I always could have missed a few. 
        As an update, instead of fully removing, I made the specific ones all one word. Got rid of the 'Gen 9 Starters +' whatever since that's not necessary, 
        but I changed 'CGC 9' to 'CGC9' so that it's still informative, but won't be picked up as a number
        */

        private void openFileButton_Click(object sender, EventArgs e)
        {
            //When the Open File button is clicked, filter for only text files, and pre-search for what I named the file ('Pokemon Collection.rtf')
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
                    var filePath = openFileDialog1.FileName; //the actual searching using the name if it worked
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        //Starting to read the file inputted, initialize important values
                        int total = 0;
                        int totalGen1 = 0, totalGen2 = 0, totalGen3 = 0, totalGen4 = 0, totalGen5 = 0, totalGen6 = 0, totalGen7 = 0, totalGen8 = 0, totalGen9 = 0;
                        bool reachedGen2 = false, reachedGen3 = false, reachedGen4 = false, reachedGen5 = false, reachedGen6 = false, reachedGen7 = false,
                            reachedGen8 = false, reachedGen9 = false, reachedEnd = false;

                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            //While there's still lines to read, check if we've reached "Generation 2". If we have, update the boolean to separate
                            //totals into the different generations
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

                                //As of 4/12, I don't think this is necessary? Keeping just in case I suppose. 
                                continue;
                            }

                            //Split the line into words (NOTE: Porygon2 will not count as '2', nor will Misty's Starmie CGC9.5 as '9.5', since it tests the whole word as an Int)
                            string[] words = line.Split(' ');
                            for (int i = 0; i < words.Length; i++)
                            {
                                if (words[i].StartsWith("("))
                                {
                                    //For every first value (i.e. Voltorb (10 normal), splitting by Spaces would mean it tries to see if "(10" is a number. 
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
                                    //Sum regardless for the total
                                    total += number;
                                }
                            }
                        }

                        //Display the sums in the text boxes, make everything visible whilst hiding the OpenFile button
                        openFileButton.Visible = false;
                        totalText.Text = $"Excluding trainer cards, I have {total:n0} Pokemon Cards!\nMy favorite generation is either 5 or 4 (if you include " +
                            $"Legends Arceus). My favorite Pokemon designs come from Gen 8, although 6, 9, and 4 are all close. \nThe display cards " +
                            $"for each generation are my favorite Pokemon's best card (imo - excluding Dragapult, the official Pokemon TCG doesn't have the " +
                            $"'Dragapult Prime' card).\nThe Grookey line is my favorite starter, " +
                            $"Yveltal is my favorite Legendary, and Darkrai my favorite overall.\nMy favorite card of all time is Charizard Star " +
                            $"(Delta Species) from Dragon Frontiers, since I distinctly remember having that card as a kid.";
                        /*By the way - I could get a photo of the Dragapult Prime off of the Internet, but it won't be HD, and the background will be bad
                        (Non transparent, and online background removers/ones that make it transparent have a hard time with a non standard image such as a 
                        trading card)*/
                        textGen1.Text = $"{totalGen1:n0} cards from Generation 1!";
                        textGen2.Text = $"{totalGen2:n0} cards from Generation 2!";
                        textGen3.Text = $"{totalGen3:n0} cards from Generation 3!";
                        textGen4.Text = $"{totalGen4:n0} cards from Generation 4!";
                        textGen5.Text = $"{totalGen5:n0} cards from Generation 5!";
                        textGen6.Text = $"{totalGen6:n0} cards from Generation 6!";
                        textGen7.Text = $"{totalGen7:n0} cards from Generation 7!";
                        textGen8.Text = $"{totalGen8:n0} cards from Generation 8!";
                        textGen9.Text = $"{totalGen9:n0} cards from Generation 9!";
                        gen1Card.Visible = true;
                        gen2Card.Visible = true;
                        gen3Card.Visible = true;
                        gen4Card.Visible = true;
                        gen5Card.Visible = true;
                        gen6Card.Visible = true;
                        gen7Card.Visible = true;
                        gen8Card.Visible = true;
                        gen9Card.Visible = true;
                        textGen1.Visible = true;
                        textGen2.Visible = true;
                        textGen3.Visible = true;
                        textGen4.Visible = true;
                        textGen5.Visible = true;
                        textGen6.Visible = true;
                        textGen7.Visible = true;
                        textGen8.Visible = true;
                        textGen9.Visible = true;
                        welcomeText.Visible = true;
                        totalText.Visible = true;
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
