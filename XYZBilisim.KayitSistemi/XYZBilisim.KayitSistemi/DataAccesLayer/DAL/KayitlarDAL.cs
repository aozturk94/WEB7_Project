using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZBilisim.KayitSistemi.EntityLayer;
using System.Data.SqlClient;
using XYZBilisim.KayitSistemi.DataAccesLayer.ConnectionsLayer;

namespace XYZBilisim.KayitSistemi.DataAccesLayer.DAL
{
    class KayitlarDAL
    {
        public List<Kayit> GetAll(string condition = "")
        {
            List<Kayit> kayitlar = new List<Kayit>();
            string query = $"SELECT*FROM tblKursiyerler {condition}";
            try
            {
                using (SqlCommand command = new SqlCommand(query, SQLConnection.Connection))
                {
                    SQLConnection.ConnectionOpen();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Kayit kayit = new Kayit
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                AdSoyad = reader["AdSoyad"].ToString(),
                                EgiticiAdSoyad = reader["EgiticiAdSoyad"].ToString(),
                                Yil = Convert.ToInt32(reader["Yil"])
                            };
                            kayitlar.Add(kayit);
                        }
                    }
                }
                return kayitlar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                SQLConnection.ConnectionClose();
            }
        }
        public bool Insert(Kayit kayit)
        {
            string query = $"INSERT INTO tblKursiyerler (AdSoyad, EgiticiAdSoyad, Yil) " +
                $"VALUES (@p1,@p2,@p3)";
            try
            {
                using (SqlCommand command = new SqlCommand(query, SQLConnection.Connection))
                {
                    command.Parameters.AddWithValue("@p1", kayit.AdSoyad);
                    command.Parameters.AddWithValue("@p2", kayit.EgiticiAdSoyad);
                    command.Parameters.AddWithValue("@p3", kayit.Yil);
                    SQLConnection.ConnectionOpen();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                SQLConnection.ConnectionClose();
            }

        }
        public bool Delete(int id)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM tblKursiyerler WHERE ID=@p1", SQLConnection.Connection))
                {
                    command.Parameters.AddWithValue("@p1", id);
                    SQLConnection.ConnectionOpen();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                SQLConnection.ConnectionClose();
            }
        }
        public bool Update(Kayit kayit)
        {
            string query = $"UPDATE tblKursiyerler SET AdSoyad=@p1, EgiticiAdSoyad=@p2, Yil=@p3";
            try
            {
                using (SqlCommand command = new SqlCommand(query, SQLConnection.Connection))
                {
                    command.Parameters.AddWithValue("@p1", kayit.AdSoyad);
                    command.Parameters.AddWithValue("@p2", kayit.EgiticiAdSoyad);
                    command.Parameters.AddWithValue("@p3", kayit.Yil);
                    SQLConnection.ConnectionOpen();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                SQLConnection.ConnectionClose();
            }
        }
        public bool Delete(string condition = "")
        {
            try
            {
                using (SqlCommand command = new SqlCommand($"DELETE FROM tblKursiyerler {condition}", SQLConnection.Connection))
                {
                    SQLConnection.ConnectionOpen();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                SQLConnection.ConnectionClose();
            }
        }
        public Kayit GetSpecific(string condition)
        {
            Kayit kayit = null;
            try
            {
                int adet = 0;
                using (SqlCommand command = new SqlCommand($"SELECT COUNT (*) FROM tblKursiyerler {condition}", SQLConnection.Connection))
                {
                    SQLConnection.ConnectionOpen();
                    adet = Convert.ToInt32(command.ExecuteScalar()); //Bizim veri tabanındaki sorgumuzun tek satır tek sutun değer üreteceğini bilip ola göre değer tutar.
                }
                if (adet == 0)
                {
                    MessageBox.Show("Aradığınız kayıt bulunamadı!\nLütfen kriterlerinizi kontrol ederek tekrar deneyiniz.");
                    kayit = null;
                }
                else if (adet > 1)
                {
                    MessageBox.Show("Birden fazla kayıtla karşılaşıldı!\nLütfen kriterlerinizi daraltıp tekrar deneyiniz.");
                    kayit = null;
                }
                else
                {
                    using (SqlCommand command = new SqlCommand($"SELECT * FROM tblKursiyerler {condition}", SQLConnection.Connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                kayit = new Kayit
                                {
                                    ID = Convert.ToInt32(reader["ID"]),
                                    AdSoyad = reader["AdSoyad"].ToString(),
                                    EgiticiAdSoyad = reader["EgiticiAdSoyad"].ToString(),
                                    Yil = Convert.ToInt32(reader["Yil"])
                                };
                            }
                        }
                    }
                }
                return kayit;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                SQLConnection.ConnectionClose();
            }
        }
    }
}
