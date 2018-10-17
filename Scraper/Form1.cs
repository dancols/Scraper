using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Scraper {
    public partial class frmScraper : Form {
        private const string WebURL = "http://www.diariooficial.gob.mx/indicadores_detalle.php";
        private const string MobileURL = "http://www.dof.gob.mx/DOFmobile/indicadores.php";
                
        public frmScraper() {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e) {
            this.txtResults.Text = "Requesting...";
            string exchangeRate = GetExchangeRate(this.dteLookupDate.Value);
            this.txtResults.Text = exchangeRate;
        }

        private string GetExchangeRate(DateTime lookupDate) {
            string url;
            // url = GetWebURL(lookupDate.Day.ToString().PadLeft(2, '0'), lookupDate.Month.ToString().PadLeft(2, '0'), lookupDate.Year.ToString());
            url = GetMobileURL(lookupDate.Day.ToString().PadLeft(2,'0'), lookupDate.Month.ToString().PadLeft(2, '0'), lookupDate.Year.ToString());
            
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();

            // string status = ((HttpWebResponse)response).StatusDescription;

            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string content = reader.ReadToEnd();

            reader.Close();
            response.Close();

            // Parse out the exchange rate (for MobileURL)
            // snippet can be set by configuration (country code) in case the web page's markup is changed
            string snippet = "<span class=\"unidades\"><b>DOLAR:</b> </span><span class=\"cantidad\">";

            string exchangeRate;

            if (content.Contains(snippet)) {
                int start = content.IndexOf(snippet);
                exchangeRate = content.Substring(start + snippet.Length, 9);
            } else {
                exchangeRate = "Exchange rate not found for " + lookupDate.ToShortDateString() + ".";
            }

            return exchangeRate;
        }

        private string GetWebURL(string day, string month, string year) {
            // ?cod_tipo_indicador=158&dfecha=08%2F10%2F2018&hfecha=08%2F10%2F2018
            string formattedDate = day + "%2F" + month + "%2F" + year;
            string url = WebURL + "?cod_tipo_indicador=158&dfecha=" + formattedDate + "&hfecha=" + formattedDate;
            return url;
        }

        private string GetMobileURL(string day, string month, string year) {
            // ?cod_tipo_indicador=158&diaD=10&mesD=10&anioD=2018&diaH=10&mesH=10&anioH=2018
            string formattedDate = "diaD=" + day + "&mesD=" + month + "&anioD=2018&";
            formattedDate += "diaH=" + day + "&mesH=" + month + "&anioH=2018";
            string url = MobileURL + "?cod_tipo_indicador=158&" + formattedDate;
            return url;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

    }
}
