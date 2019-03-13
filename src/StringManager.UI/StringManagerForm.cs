using StringManager.Domain;
using StringManager.Domain.Enums;
using System;
using System.Windows.Forms;

namespace StringManager.UI
{
    public partial class StringManagerForm : MetroFramework.Forms.MetroForm
    {
        public StringManagerForm()
        {
            InitializeComponent();
            SignEvents();
        }

        private void SignEvents()
        {
            btnConverter.Click += btnConverter_Click;
            btnClear.Click += btnClear_Click;
        }

        private void ConvertString()
        {
            var strManagerParam = FillStrManagerParam();
            var strManagerService = new StringManagerService(strManagerParam);
            var stringDest = strManagerService.GetNewString();

            txtStrDest.Text = stringDest;
        }

        private StringManagerParam FillStrManagerParam()
        {
            var strManagerParam = new StringManagerParam();
            SetConverterType(strManagerParam);
            strManagerParam.StringToConverter = txtStrSource.Text;
            strManagerParam.SplitPerLine = chkSplitByLine.Checked;
            strManagerParam.StartWith = txtStartWith.Text.Trim();
            strManagerParam.EndWith = txtEndWith.Text.Trim();

            return strManagerParam;
        }

        private void SetConverterType(StringManagerParam strManagerParam)
        {
            if (radioNone.Checked)
                strManagerParam.ConverterType = ConverterTypeEnum.None;

            if (radioUpper.Checked)
                strManagerParam.ConverterType = ConverterTypeEnum.Upper;

            if (radioLower.Checked)
                strManagerParam.ConverterType = ConverterTypeEnum.Lower;

            if (radioFirstUpper.Checked)
                strManagerParam.ConverterType = ConverterTypeEnum.FirstUpper;
        }

        private void CleanFieldsString()
        {
            txtStrSource.Text = string.Empty;
            txtStrDest.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                CleanFieldsString();
            }
            catch (Exception ex)
            {
                MessaError(ex.Message);
            }
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            try
            {
                ConvertString();
            }
            catch (Exception ex)
            {
                MessaError(ex.Message);
            }
        }

        private void MessaSuccess(string message = "Operação realizada com sucesso")
        {
            MessageBox.Show(message, "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MessaError(string error)
        {
            MessageBox.Show(error, "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
