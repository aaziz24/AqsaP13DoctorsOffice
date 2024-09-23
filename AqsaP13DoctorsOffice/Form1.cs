namespace AqsaP13DoctorsOffice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double taxRate = .0875;
            double rate, totalRate
            string PatientName;

            //input
            price = double.Parse(txtInsuranceRate.Text);
            PatientName = txtInsuranceRate.Text;

            //processing
            totalRate = (rate * taxRate) + price;
            totalPrice = price + taxAmount;

            //output
            lstOut.Items.Add("Patient Name is " + PatientName);
            lstOut.Items.Add("Price is " + price.ToString("C2"));
            lstOut.Items.Add("tax amount is " + taxAmount.ToString("C2"));
            lstOut.Items.Add("Total Price is " + totalPrice);

            //This changes the focus to the clear button
            //btnClear.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPatientName.Clear();
            txtInsuranceType.Clear();
            lstOut.Items.Clear();
            txtPatientName.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close():
        }

        private void txtPatientName_Enter(object sender, EventArgs e)
        {
            txtPatientName.Backcolor = Color.White Bisque;
        }

        private void txtPatientName_leave(object sender, EventArgs e)
        {
            txtPatientName.Backcolor = SystemColors.Window;
        }
    }
}
