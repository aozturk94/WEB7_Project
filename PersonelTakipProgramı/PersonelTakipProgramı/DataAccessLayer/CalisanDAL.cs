using PersonelTakipProgramı.EntityLayer;
using PersonelTakipProgramı.ToolsLayer.Connections;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipProgramı.DataAccessLayer
{
    class CalisanDAL
    {
        public List<Calisan> GetAll(string condition="")
        {
            List<Calisan> calisanlar = new List<Calisan>();
            string query = $"SELECT*FROM tblCalisanlar {condition}";
            try
            {
                using (SqlCommand command = new SqlCommand(query, SQLConnection.Connection))
                {
                    //Yukarıda yaratılmış olan command nesnesi bu scope içinde yaşayacak.
                    //Scope'un bittiği yerden itibaren Garbage Collector'u beklemeden bellekten atılmış olacak.
                    SQLConnection.ConOpen();

                    using (SqlDataReader reader=command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Calisan calisan = new Calisan
                            {
                                ID = Convert.ToInt32(reader["ID"]),
                                Ad = reader["Ad"].ToString(),
                                Soyad = reader["Soyad"].ToString(),
                                TcNo = reader["TcNo"].ToString(),
                                PersonelNo = reader["PersonelNo"].ToString(),
                                DogumTarihi = Convert.ToDateTime(reader["DogumTarihi"]),
                                IseBaslamaTarihi = Convert.ToDateTime(reader["IseBaslamaTarihi"]),
                                Departman = reader["Departman"].ToString(),
                                Unvan = reader["Unvan"].ToString(),
                                Durumu = reader["Durumu"].ToString()
                            };
                            calisanlar.Add(calisan);
                        }
                    }
                }
                return calisanlar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                //finally bloğu, ister try bölümü isterse de catch bölümü çalışşsın;
                //her halükarda çalışmasını istediğimiz kodları yazmak için vardır.
                SQLConnection.ConClose();
            }
        }
        public bool Insert(Calisan calisan)
        {
            string query = $"INSERT INTO tblCalisanlar " +
                $"(Ad,Soyad,TcNo,PersonelNo,DogumTarihi,IseBaslamaTarihi,Departman,Unvan,Durumu) " +
                $"VALUES " +
                $"(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)";

            try
            {
                using (SqlCommand command = new SqlCommand(query,SQLConnection.Connection))
                {
                    command.Parameters.AddWithValue("@p1", calisan.Ad);
                    command.Parameters.AddWithValue("@p2", calisan.Soyad);
                    command.Parameters.AddWithValue("@p3", calisan.TcNo);
                    command.Parameters.AddWithValue("@p4", calisan.PersonelNo);
                    command.Parameters.AddWithValue("@p5", calisan.DogumTarihi.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@p6", calisan.IseBaslamaTarihi.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@p7", calisan.Departman);
                    command.Parameters.AddWithValue("@p8", calisan.Unvan);
                    command.Parameters.AddWithValue("@p9", calisan.Durumu);
                    SQLConnection.ConOpen();
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
                SQLConnection.ConClose();
            }
        }
        public bool Delete(int id)
        {
            try
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM tblCalisanlar WHERE ID=@p1",SQLConnection.Connection))
                {
                    command.Parameters.AddWithValue("@p1", id);
                    SQLConnection.ConOpen();
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
                SQLConnection.ConClose();
            }
        }
        public bool Delete(string condition = "")//Overload
        {
            try
            {
                using (SqlCommand command = new SqlCommand($"DELETE FROM tblCalisanlar {condition}", SQLConnection.Connection))
                {
                    SQLConnection.ConOpen();
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
                SQLConnection.ConClose();
            }
        }
        public bool Update(Calisan calisan)
        {
            string query = $@"UPDATE tblCalisanlar SET 
            Ad=@p1,Soyad=@p2,TcNo=@p3,PersonelNo=@p4,DogumTarihi=@p5,
            IseBaslamaTarihi=@p6,Departman=@p7,Unvan=@p8,Durumu=@p9 WHERE ID=@p10";

            try
            {
                using (SqlCommand command = new SqlCommand(query, SQLConnection.Connection))
                {
                    command.Parameters.AddWithValue("@p1", calisan.Ad);
                    command.Parameters.AddWithValue("@p2", calisan.Soyad);
                    command.Parameters.AddWithValue("@p3", calisan.TcNo);
                    command.Parameters.AddWithValue("@p4", calisan.PersonelNo);
                    command.Parameters.AddWithValue("@p5", calisan.DogumTarihi);
                    command.Parameters.AddWithValue("@p6", calisan.IseBaslamaTarihi);
                    command.Parameters.AddWithValue("@p7", calisan.Departman);
                    command.Parameters.AddWithValue("@p8", calisan.Unvan);
                    command.Parameters.AddWithValue("@p9", calisan.Durumu);
                    command.Parameters.AddWithValue("@p10", calisan.ID);
                    SQLConnection.ConOpen();
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
                SQLConnection.ConClose();
            }
        }
    }
}
