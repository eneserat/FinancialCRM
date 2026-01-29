using System;
using System.Windows.Forms;
using FinancialCrm.Models;
using System.Linq;
namespace FinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db= new FinancialCrmDbEntities();

        private void FrmBanks_Load(object sender, EventArgs e)

        {
           
        

            //Banka Bakiyeleri
            var ZiraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault();
            var VakifbankBalance = db.Banks.Where(x => x.BankTitle == "Vakıfbank").Select(y => y.BankBalance).FirstOrDefault();
            var İsBankasiBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();

            lblVakifbankBalance.Text = VakifbankBalance.ToString() + " ₺";
            lblZiraatBankBalance.Text = ZiraatBankBalance. ToString() + " ₺";
            lblİsBankasiBalance.Text = İsBankasiBalance.ToString() + " ₺";

            //Banka Hareketleri
            var BankProcess1=db.BankProcesses.OrderByDescending(x=>x.BankProcessId). Take(1).FirstOrDefault();
            lblBankProcess1.Text = BankProcess1.Description + " " + BankProcess1.Amount + " " + BankProcess1.ProcessDate;

            var BankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2) .Skip(1).FirstOrDefault();
            lblBankProcess2.Text = BankProcess2.Description + " " + BankProcess2.Amount + " " + BankProcess2.ProcessDate;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmBanks_Load_1(object sender, EventArgs e)
        {

            //Banka Bakiyeleri
            var ZiraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault();
            var VakifbankBalance = db.Banks.Where(x => x.BankTitle == "Vakıfbank").Select(y => y.BankBalance).FirstOrDefault();
            var İsBankasiBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();

            lblVakifbankBalance.Text = VakifbankBalance.ToString() + " ₺";
            lblZiraatBankBalance.Text = ZiraatBankBalance.ToString() + " ₺";
            lblİsBankasiBalance.Text = İsBankasiBalance.ToString() + " ₺";

            //Banka Hareketleri
            var BankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = BankProcess1.Description + " " + BankProcess1.Amount + " " + BankProcess1.ProcessDate;

            var BankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = BankProcess2.Description + " " + BankProcess2.Amount + " " + BankProcess2.ProcessDate;

            var BankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = BankProcess3.Description + " " + BankProcess3.Amount + " " + BankProcess3.ProcessDate;

        }
    }
} 
