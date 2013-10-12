using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ConvAdapt
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonApplyConvention_Click(object sender, EventArgs e)
        {
            if (tabControlText.SelectedTab == tabPageTextBox)
                textBoxReplaced.Text = ApplyConvention(textBoxOriginal.Text);
            else if (tabControlText.SelectedTab == tabPageFiles && openFileDialog1.FileNames.Length > 0 && (folderBrowserDialog1.SelectedPath != ""))
            {
                try
                {
                    if (radioButtonSaveAtOtherLocation.Checked)
                        foreach (string file in openFileDialog1.FileNames)
                        {
                            string path = Path.Combine(folderBrowserDialog1.SelectedPath, Path.GetFileName(file));
                            System.IO.File.WriteAllText(path, ApplyConvention(System.IO.File.ReadAllText(file, Encoding.UTF8)),Encoding.UTF8);
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string ApplyConvention(string text)
        {
             if (checkBoxUseSearchFilter.Checked)
            {
                return  Regex.Replace(text, textBoxSearchPattern.Text, delegate(Match match)
                {
                    string s = match.ToString();
                    string replacedMatchText="";
                    if (match.Groups["start"].Success)
                        replacedMatchText += match.Groups["start"].ToString();
                    if (match.Groups["obj"].Success)
                        replacedMatchText += Replace(match.Groups["obj"].ToString());
                    if (match.Groups["end"].Success)
                        replacedMatchText += match.Groups["end"].ToString();
                    return replacedMatchText;
                });
            }
            else
                return Replace(text);
        }

        private string Replace(string text)
        {
            Action underscoreAtStartAction = GetUnderscoreAtStartAction();
            Action firstLetterAction = ChangeCaseSensitivityOfFirstLetter();
            bool lowerText = checkBoxLowerText.Checked;
            bool capitalizeLetterAfterUnderscore = checkBoxCapitalizeLetterAfterUnderscore.Checked;
            bool useSearchFilter = checkBoxUseSearchFilter.Checked;

            if (radioButtonCamelCase.Checked)
                return TextConverter.ApplyCamelCase(text, lowerText, underscoreAtStartAction, firstLetterAction);
            else
                return TextConverter.ApplyUnderscoreCase(text, capitalizeLetterAfterUnderscore, lowerText, underscoreAtStartAction, firstLetterAction);
        }

        private Action GetUnderscoreAtStartAction()
        {
            if (radioButtonRemoveUnderscoreAtStart.Checked)
                return Action.Two;
            else if (radioButtonInsertUnderscoreAtStart.Checked)
                return Action.One;
            else
                return Action.Ignore;
        }

        private Action ChangeCaseSensitivityOfFirstLetter()
        {
            if (radioButtonLowerFirstLetter.Checked)
                return Action.Two;
            else if (radioButtonCapitalizeFirstLetter.Checked)
                return Action.One;
            else
                return Action.Ignore;
        }

        private void textBoxOriginal_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxInstantApply.Checked)
                buttonApplyConvention.PerformClick();
        }

        private void buttonChangePath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                textBoxSavePath.Text = folderBrowserDialog1.SelectedPath;
            
        }

        private void buttonChangeOpenPath_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxOpenPath.Text = openFileDialog1.FileName;
                listBoxFiles.Items.Clear();
                foreach (string file in openFileDialog1.FileNames)
                    listBoxFiles.Items.Add(Path.GetFileName(file));
            }
        }
    }
}