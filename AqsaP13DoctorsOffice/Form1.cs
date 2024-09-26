namespace AqsaP13DoctorsOffice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //this will end the program
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //this will clear the textbox and anything in listbox 
            PatientName.Clear();
            txtAmount_Text = string.Empty;
            lstOut.Items.Clear();
            txtPatientName.Focus();
        }

        private void txtPatientName_Enter(object sender, EventArgs e)
        {
            PatientName.Backcolor = Color.Blue;

        }

        private void txtPatientName_Leave(object sender, EventArgs e)
        {
            PatientName.Backcolor = SystemColors.Windows;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string PatientName;
            double Amount;
            double TotalPrice, InsuranceAmount;

            double InsuranceRate = 0.05;

            //input
            PatientName = PatientName.Text;
            Amount = double.Parse(txtAmount.Text);

            //processing
            InsuranceAmount = Amount * InsuranceRate;
            TotalPrice = Amount + InsuranceAmount;

            //output
            lstOut.Items.Add("Your patient name is" + PatientName);
            lstOut.Items.Add("The amount is" + Amount.ToString("C"));
            lstOut.Items.Add("The insurance is" + InsuranceAmount.ToString("C")) +
                "(" + InsuranceRate.ToString("P") + ")"); ; }
            lstOut.Items.Add("Your total amount is " + TotalPrice.ToString("C"));


        }
    }
}
            
            
            
            
            
            
           
