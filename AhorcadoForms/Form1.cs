using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhorcadoForms
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxInputWord.Hide();
            labelInputWord.Hide();
            buttonInputWord.Hide();
            Reference.h = new HiddenWord(textBoxInputWord.TextLength, textBoxInputWord.Text);
            Reference.h.HiddeWord();
            string s = new string (Reference.h.GetHiddenWordArray());
            labelHiddenWord.Text = s;
        }

        private void buttonInputChar_Click(object sender, EventArgs e)
        {
            char letter = textBoxInputChar.Text[0];
            Reference.w = new Word(Reference.h,ref letter);
            if (Utilidades.CheckChar(letter, Reference.inLetter, Reference.w.GetCharArray()))
            {
                Reference.inLetter[Reference.tries] = letter;
                Reference.w.WriteChar();
                labelHiddenWord.Text = new string(Reference.h.GetHiddenWordArray());
                Reference.tries++;
            }
            else if (!(Reference.w.GetCharArray().Contains(letter)) && (!(Reference.inLetter.Contains(letter))))
            {
                Reference.inLetter[Reference.tries] = letter;
                Reference.errores++;
                Reference.tries++;
            }
            else
            {
                MessageBox.Show("Letra ya introducida");
            }

               switch (Reference.errores)
                {
                    case 1:
                        pictureBox.Image = Properties.Resources.ahorcado_2;
                        break;
                    case 2:
                        pictureBox.Image = Properties.Resources.ahorcado_3;
                        break;
                    case 3:
                        pictureBox.Image = Properties.Resources.ahorcado_3;
                        break;
                    case 4:
                        pictureBox.Image = Properties.Resources.ahorcado_4;
                        break;
                    case 5:
                        pictureBox.Image = Properties.Resources.ahorcado_5;
                        break;
                    case 6:
                        pictureBox.Image = Properties.Resources.ahorcado_6;
                        break;
                    case 7:
                        pictureBox.Image = Properties.Resources.ahorcado_7;
                        break;
                    case 8:
                        pictureBox.Image = Properties.Resources.ahorcado_8;
                        break;
                    case 9:
                        pictureBox.Image = Properties.Resources.ahorcado_9;
                        break;
                    default:
                        break;
                }
            }
        }
    }
