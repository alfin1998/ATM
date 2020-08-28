using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM {
    public partial class Form1 : Form {
        private Nasabah currentNasabah;
        public Form1() {
            InitializeComponent();
            simulasiLogin();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        public void simulasiLogin() {
            Rekening r = new Rekening(5000000);
            Nasabah alim = new Nasabah(r, "Syaikhul", "Alim");
            currentNasabah = alim;
        }

        private void buttonCekSaldo_Click(object sender, EventArgs e) {
            textBoxInfo.AppendText("Nasabah : " + currentNasabah.mfname);
            textBoxInfo.AppendText("\nSaldo anda : " + currentNasabah.mRekening.mSaldo);
            textBoxInfo.AppendText(Environment.NewLine);
        }

        private void button0_Click(object sender, EventArgs e) {
            textBoxInput.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e) {
            textBoxInput.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e) {
            textBoxInput.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e) {
            textBoxInput.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e) {
            textBoxInput.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e) {
            textBoxInput.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e) {
            textBoxInput.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e) {
            textBoxInput.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e) {
            textBoxInput.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e) {
            textBoxInput.Text += "9";
        }

        private void buttonClear_Click(object sender, EventArgs e) {
            textBoxInput.Text = null;
        }

        private void buttonSetor_Click(object sender, EventArgs e) {
            currentNasabah.mRekening.setor(Convert.ToDouble(textBoxInput.Text));
            textBoxInfo.AppendText("Anda menyetor : " + textBoxInput.Text);
            textBoxInfo.AppendText(Environment.NewLine);
            textBoxInfo.AppendText("Saldo anda : " + currentNasabah.mRekening.mSaldo);
            textBoxInfo.AppendText(Environment.NewLine);
        }

        private void buttonTarik_Click(object sender, EventArgs e) {
            currentNasabah.mRekening.tarik(Convert.ToDouble(textBoxInput.Text));
            textBoxInfo.AppendText("Anda menarik : " + textBoxInput.Text);
            textBoxInfo.AppendText(Environment.NewLine);
            textBoxInfo.AppendText("Saldo anda : " + currentNasabah.mRekening.mSaldo);
            textBoxInfo.AppendText(Environment.NewLine);
        }

        private void textBoxInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
