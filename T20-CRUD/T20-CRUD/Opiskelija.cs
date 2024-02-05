using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T20_CRUD
{
    internal class Opiskelija
    {
        Yhdista yhteys = new Yhdista();
        public bool lisaaOpiskelija(String enimi, String snimi, String puh, String email, int onro)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO Yhteystiedot (etunimi, sukunimi, puhelin, sahkoposti, opiskelijanumero) VALUES (@enm, @snm, @puh, @eml, @ono); ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@ono", MySqlDbType.VarChar).Value = onro;

            yhteys.avaaYhteys();
            if(komento.ExecuteNonQuery() == 1) {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
        public DataTable haeOpiskelijat()
        {
            MySqlCommand komento = new MySqlCommand("Select * FROM Yhteystiedot", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();
            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }
        public bool muokkaaOpiskelijaa()
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE yhteystiedot SET etunimi = @enm, sukunimi = @snm, puhelin =  @puh, sahkoposti = @eml, opiskelijanro = @ono WHERE oid = @oid";
            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.otaYhteys();


        }
    }
    
}
