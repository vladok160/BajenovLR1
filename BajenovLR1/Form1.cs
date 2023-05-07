namespace BajenovLR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void StartPassiveSearch_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(X0.Text) >= 0 || Convert.ToDouble(X1.Text) >= 1)
            {
                MessageBox.Show("� ������ ������ X0 ������ ���� ������ ������ 0\n� X1 ������ ������ 1", "������");
            }
            else
            {
                Pass_poiska poisk = new Pass_poiska(
                    Convert.ToDouble(X0.Text),
                    Convert.ToDouble(X1.Text),
                    Convert.ToDouble(Epsilon.Text));
                ResultX.Text = Convert.ToString(poisk.ForX());
                ResultF.Text = Convert.ToString(poisk.ForF());
                Iterations.Text = Convert.ToString(poisk.GetIterations());
                ErrorRate.Text = Convert.ToString(poisk.GetErrorRate());
                TimeOfDoing.Text = Convert.ToString(poisk.TimeOfDoing());
            }
        }

        private void StartDihotomiaMethod_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(X0.Text) >= 0 || Convert.ToDouble(X1.Text) >= 1)
            {
                MessageBox.Show("� ������ ������ X0 ������ ���� ������ ������ 0\n� X1 ������ ������ 1", "������");
            }
            else
            {
                Dihotomiya poisk = new Dihotomiya(
                    Convert.ToDouble(X0.Text),
                    Convert.ToDouble(X1.Text),
                    Convert.ToDouble(Epsilon.Text));
                ResultX.Text = Convert.ToString(poisk.ForX());
                ResultF.Text = Convert.ToString(poisk.ForF());
                Iterations.Text = Convert.ToString(poisk.GetIterations());
                ErrorRate.Text = Convert.ToString(poisk.GetErrorRate());
                TimeOfDoing.Text = Convert.ToString(poisk.TimeOfDoing());
            }
        }

        private void StartGoldSearchMethod_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(X0.Text) >= 0 || Convert.ToDouble(X1.Text) >= 1)
            {
                MessageBox.Show("� ������ ������ X0 ������ ���� ������ ������ 0\n� X1 ������ ������ 1", "������");
            }
            else
            {
                Zolot_sech poisk = new Zolot_sech(
                    Convert.ToDouble(X0.Text),
                    Convert.ToDouble(X1.Text),
                    Convert.ToDouble(Epsilon.Text));
                ResultX.Text = Convert.ToString(poisk.ForX());
                ResultF.Text = Convert.ToString(poisk.ForF());
                Iterations.Text = Convert.ToString(poisk.GetIterations());
                ErrorRate.Text = Convert.ToString(poisk.GetErrorRate());
                TimeOfDoing.Text = Convert.ToString(poisk.TimeOfDoing());
            }
        }

        private void StartFibonaciMethod_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(X0.Text) >= 0 || Convert.ToDouble(X1.Text) >= 1)
            {
                MessageBox.Show("� ������ ������ X0 ������ ���� ������ ������ 0\n� X1 ������ ������ 1", "������");
            }
            else
            {
                Fibonacci poisk = new Fibonacci(
                    Convert.ToDouble(X0.Text),
                    Convert.ToDouble(X1.Text),
                    Convert.ToDouble(Epsilon.Text));
                ResultX.Text = Convert.ToString(poisk.ForX());
                ResultF.Text = Convert.ToString(poisk.ForF());
                Iterations.Text = Convert.ToString(poisk.GetIterations());
                ErrorRate.Text = Convert.ToString(poisk.GetErrorRate());
                TimeOfDoing.Text = Convert.ToString(poisk.TimeOfDoing());
            }
        }

        private void StartKasanieMethod_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(X0.Text) >= 0 || Convert.ToDouble(X1.Text) >= 1)
            {
                MessageBox.Show("� ������ ������ X0 ������ ���� ������ ������ 0\n� X1 ������ ������ 1", "������");
            }
            else
            {
                Kasatelnyh poisk = new Kasatelnyh(
                    Convert.ToDouble(X0.Text),
                    Convert.ToDouble(X1.Text),
                    Convert.ToDouble(Epsilon.Text));
                ResultX.Text = Convert.ToString(poisk.ForX());
                ResultF.Text = Convert.ToString(poisk.ForF());
                Iterations.Text = Convert.ToString(poisk.GetIterations());
                ErrorRate.Text = Convert.ToString(poisk.GetErrorRate());
                TimeOfDoing.Text = Convert.ToString(poisk.TimeOfDoing());
            }
        }

        private void StartNuRafMethod_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(X0.Text) >= 0 || Convert.ToDouble(X1.Text) >= 1)
            {
                MessageBox.Show("� ������ ������ X0 ������ ���� ������ ������ 0\n� X1 ������ ������ 1", "������");
            }
            else
            {
                NutRaf poisk = new NutRaf(
                    Convert.ToDouble(X0.Text),
                    Convert.ToDouble(X1.Text),
                    Convert.ToDouble(Epsilon.Text));
                ResultX.Text = Convert.ToString(poisk.ForX());
                ResultF.Text = Convert.ToString(poisk.ForF());
                Iterations.Text = Convert.ToString(poisk.GetIterations());
                ErrorRate.Text = Convert.ToString(poisk.GetErrorRate());
                TimeOfDoing.Text = Convert.ToString(poisk.TimeOfDoing());
            }
        }

        private void StartSekuchMethod_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(X0.Text) >= 0 || Convert.ToDouble(X1.Text) >= 1)
            {
                MessageBox.Show("� ������ ������ X0 ������ ���� ������ ������ 0\n� X1 ������ ������ 1", "������");
            }
            else
            {
                SekyshihHord poisk = new SekyshihHord(
                    Convert.ToDouble(X0.Text),
                    Convert.ToDouble(X1.Text),
                    Convert.ToDouble(Epsilon.Text));
                ResultX.Text = Convert.ToString(poisk.ForX());
                ResultF.Text = Convert.ToString(poisk.ForF());
                Iterations.Text = Convert.ToString(poisk.GetIterations());
                ErrorRate.Text = Convert.ToString(poisk.GetErrorRate());
                TimeOfDoing.Text = Convert.ToString(poisk.TimeOfDoing());
            }
        }
    }
}