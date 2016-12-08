using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using mvcApplication.Models;
using System.Web.UI.WebControls;
using WebApplication5.Models;

namespace mvcApplication.DAO
{
    public class RecordsDAO : DAO
    {
        //все записи
        public List<Records> GetAllRecords()
        {
            Connect();
            List<Records> recordList = new List<Records>();


            //чтение всей базы
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Tours", Connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Records record = new Records();
                    record.ID = Convert.ToInt32(reader["Id"]);
                    record.Image = Convert.ToString(reader["Image"]);
                    record.Name = Convert.ToString(reader["Name"]);
                    record.ShortDescription = Convert.ToString(reader["ShortDescription"]);
                    record.FullDescription = Convert.ToString(reader["FullDescription"]);
                    record.Country = Convert.ToString(reader["CName"]);
                    record.Hotel = Convert.ToString(reader["HName"]);
                    if (Convert.ToInt32(reader["gTour"]) == 1) record.gTour = "горящий"; else record.gTour = "негорящий";
                    record.Prise = Convert.ToDecimal(reader["Prise"]);
                    if (record.gTour == "горящий") record.Prise = record.Prise - (record.Prise * 10 / 100);
                    recordList.Add(record);

                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                Disconnect();
            }
            return recordList;
        }

        //заявки все
        public List<Request> ShowAllReq()
        {
            Connect();
            List<Request> reqList = new List<Request>();
            try
            {
                SqlCommand cmd = new SqlCommand(
                    "Select * from Requests", Connection);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Request req = new Request();
                    req.ID = Convert.ToInt32(reader["Id"]);
                    req.email = Convert.ToString(reader["e-mail"]);
                    req.tour = Convert.ToString(reader["Name"]);
                    req.Status = Convert.ToString(reader["Status"]);
                    reqList.Add(req);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                Disconnect();
            }
            return reqList;
        }

        //заявка одна
        public Request ShowOneReq(int id)
        {
            Connect();
            Request req = new Request();
            try
            {
                SqlCommand cmd = new SqlCommand(
                    "Select * from Requests where Id = @id", Connection);
                cmd.Parameters.Add(new SqlParameter("@id", id));
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    req.ID = Convert.ToInt32(reader["Id"]);
                    req.email = Convert.ToString(reader["e-mail"]);
                    req.tour = Convert.ToString(reader["Name"]);
                    req.Status = Convert.ToString(reader["Status"]);
                  
                }
                reader.Close();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                Disconnect();
            }
            return req;
        }

        //заявки клиента
        public List<Request> ShowReq(string email)
        {
            Connect();
            List<Request> reqList = new List<Request>();
            try
            {
                SqlCommand cmd = new SqlCommand(
                    "Select * from Requests where [e-mail] = @email", Connection);
                cmd.Parameters.Add(new SqlParameter("@email", email));
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Request req = new Request();
                    req.ID = Convert.ToInt32(reader["Id"]);
                    req.email = Convert.ToString(reader["e-mail"]);
                    req.tour = Convert.ToString(reader["Name"]);
                    req.Status = Convert.ToString(reader["Status"]);
                    reqList.Add(req);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                Disconnect();
            }
            return reqList;
        }

        //добавление тура
        public bool AddTour (Records rec)
        {
            bool result = true;
            Connect();

            try
            {
                SqlCommand cmd = new SqlCommand("Select Id from Country where Name = @name", Connection);
                cmd.Parameters.Add(new SqlParameter("@name", rec.Country));
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    rec.Country = Convert.ToString(reader["Id"]);
                }
                reader.Close();
                cmd = new SqlCommand("Select Id from Hotel where Name = @name", Connection);
                cmd.Parameters.Add(new SqlParameter("@name", rec.Hotel));
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rec.Hotel = Convert.ToString(reader["Id"]);
                }
                reader.Close();
                cmd = new SqlCommand("INSERT INTO tour ([Name], [ShortDescription], [FullDescription], [CountryId], [HotelId], [Prise], [Image], [gTour]) VALUES ( @name, @sd, @fd, @cid, @hid, @prise, @Image, @gtour)", Connection);
                
                cmd.Parameters.Add(new SqlParameter("@name", rec.Name));
                cmd.Parameters.Add(new SqlParameter("@sd", rec.ShortDescription));
                cmd.Parameters.Add(new SqlParameter("@fd", rec.FullDescription));
                cmd.Parameters.Add(new SqlParameter("@cid", rec.Country));
                cmd.Parameters.Add(new SqlParameter("@hid", rec.Hotel));
                cmd.Parameters.Add(new SqlParameter("@prise", rec.Prise));
                if (rec.gTour == "горящий") rec.gTour = "1"; else rec.gTour = "0";
                cmd.Parameters.Add(new SqlParameter("@gtour", rec.gTour));
                cmd.Parameters.Add(new SqlParameter("@Image", rec.Image));

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                Disconnect();
            }
            return result;
        }

        //Изменение тура
        public bool Edit(Records rec)
        {
            bool result = true;
            Connect();

            try
            {
                SqlCommand cmd = new SqlCommand("Select Id from Country where Name = @name", Connection);
                cmd.Parameters.Add(new SqlParameter("@name", rec.Country));
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    rec.Country = Convert.ToString(reader["Id"]);
                }
                reader.Close();
                cmd = new SqlCommand("Select Id from Hotel where Name = @name", Connection);
                cmd.Parameters.Add(new SqlParameter("@name", rec.Hotel));
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rec.Hotel = Convert.ToString(reader["Id"]);
                }
                reader.Close();
                cmd = new SqlCommand(
                "UPDATE Tour SET Name = @name, ShortDescription = @sd, FullDescription = @fd, CountryId = @cid, HotelId = @hid, Prise = @prise, gTour=@gtour, Image = @Image WHERE Id = @ID", Connection);
                cmd.Parameters.Add(new SqlParameter("@ID", rec.ID));
                cmd.Parameters.Add(new SqlParameter("@name", rec.Name));
                cmd.Parameters.Add(new SqlParameter("@sd", rec.ShortDescription));
                cmd.Parameters.Add(new SqlParameter("@fd", rec.FullDescription));
                cmd.Parameters.Add(new SqlParameter("@cid", rec.Country));
                cmd.Parameters.Add(new SqlParameter("@hid", rec.Hotel));
                cmd.Parameters.Add(new SqlParameter("@prise", rec.Prise));
                if (rec.gTour == "горящий") rec.gTour = "1"; else rec.gTour="0";
                cmd.Parameters.Add(new SqlParameter("@gtour", rec.gTour));
                cmd.Parameters.Add(new SqlParameter("@Image", rec.Image));

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                Disconnect();
            }
            return result;
        }

        //добавление страны
        public bool AddCountry(string Country, string Visa)
        {
            bool result = true;
            Connect();

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Country ([Name], [Visa] ) VALUES ( @country, @visa)", Connection);
                cmd.Parameters.Add(new SqlParameter("@country", Country));
                cmd.Parameters.Add(new SqlParameter("@visa", Visa));
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                Disconnect();
            }
            return result;
        }

        //добавление отеля
        public bool AddHotel(string Hotel, string Stars)
        {
            bool result = true;
            Connect();

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Hotel ([Name], [Stars]) VALUES (@hotel, @stars)", Connection);
                cmd.Parameters.Add(new SqlParameter("@hotel", Hotel));
                cmd.Parameters.Add(new SqlParameter("@stars", Stars));
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                Disconnect();
            }
            return result;
        }

        //добавление заявки
        public bool AddReq(string email, int id_tour)
         {
             bool result = true;
             Connect();

            try
             {
                 SqlCommand cmd = new SqlCommand("INSERT INTO[dbo].[Request]([e-mail], [id_tour], [Status]) VALUES ( @mail, @id_t, @stat)", Connection);
                 cmd.Parameters.Add(new SqlParameter("@mail", email));
                 cmd.Parameters.Add(new SqlParameter("@id_t", id_tour));
                 cmd.Parameters.Add(new SqlParameter("@stat", 2));

                 cmd.ExecuteNonQuery();
          }
             catch (Exception)
             {
                 result = false;
             }
             finally
             {
                 Disconnect();
             }
             return result;
         }

        //3 случайные
        public List<Records> RandDetails()
        {
            Records record = new Records();
            List<Records> rec1 = new List<Records>();
            List<Records> rec = GetAllRecords();
            Random ran = new Random();
            int [] ind = new int[rec.Count];
            int n = 3;
            for (int i = 0; i < n; i++) { ind[i] = 0; }
                for (int i= 0; i < n; i++){
                int rn = ran.Next(0, (rec.Count));
                if (ind[rn] == 0)
                {
                    ind[rn] = 1;
                }
                else {
                    while (ind[rn] != 0) {
                        rn = ran.Next(0, (rec.Count));
                    }
                    ind[rn] = 1;
                }
                rec1.Add(rec[rn]);
            }
            return rec1;
        }

        //одна запись
        public Records AddDetails(int id)
        {
            Connect();
            Records record = new Records();
            try
            {
                SqlCommand cmd = new SqlCommand(
                    "Select * from Tours where Id = @ID ", Connection);
                cmd.Parameters.Add(new SqlParameter("@ID", id));
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    record.ID = Convert.ToInt32(reader["Id"]);
                    record.Image = Convert.ToString(reader["Image"]);
                    record.Name = Convert.ToString(reader["Name"]);
                    record.ShortDescription = Convert.ToString(reader["ShortDescription"]);
                    record.FullDescription = Convert.ToString(reader["FullDescription"]);
                    record.Country = Convert.ToString(reader["CName"]);
                    record.Hotel = Convert.ToString(reader["HName"]);
                    if (Convert.ToInt32(reader["gTour"]) == 1) record.gTour = "горящий"; else record.gTour = "негорящий";
                    record.Prise = Convert.ToDecimal(reader["Prise"]);
                    if (record.gTour == "горящий") record.Prise = record.Prise - (record.Prise*10/100);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                Disconnect();
            }
            return record;
        }

        //фильтр
        public List<Records> Filter(String Country, String Visa, String Stars, String Gor)
        {
            Connect();
            List<Records> recordList = new List<Records>();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Tours where (gTour like @Gor) and (CName like @country) and (CName in (Select Name from Country where Visa like @visa)) and ( HName in (Select Name from Hotel where Stars >= @stars))", Connection);
                cmd.Parameters.Add(new SqlParameter("@country", Country));
                cmd.Parameters.Add(new SqlParameter("@visa", Visa));
                cmd.Parameters.Add(new SqlParameter("@stars", Stars));
                cmd.Parameters.Add(new SqlParameter("@gor", Gor));
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Records record = new Records();
        record.ID = Convert.ToInt32(reader["Id"]);
                    record.Image = Convert.ToString(reader["Image"]);
                    record.Name = Convert.ToString(reader["Name"]);
                    record.ShortDescription = Convert.ToString(reader["ShortDescription"]);
                    record.FullDescription = Convert.ToString(reader["FullDescription"]);
                    record.Country = Convert.ToString(reader["CName"]);
                    record.Hotel = Convert.ToString(reader["HName"]);
                    if (Convert.ToInt32(reader["gTour"]) == 1) record.gTour = "горящий"; else record.gTour = "негорящий";
                    record.Prise = Convert.ToDecimal(reader["Prise"]);
                    if (record.gTour == "горящий") record.Prise = record.Prise - (record.Prise * 10 / 100);
                    recordList.Add(record);
                }
    reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                Disconnect();
            }
            return recordList;
        }
        
        //изменение статуса заявки
       public bool StatReq(int id, String Status)
        {
            bool result = true;
            Connect();

            try
            {
                SqlCommand cmd = new SqlCommand(
                "UPDATE Request SET Status = @status WHERE Id = @ID", Connection);
                cmd.Parameters.Add(new SqlParameter("@ID", id));
                cmd.Parameters.Add(new SqlParameter("@Status", Status));

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                Disconnect();
            }
            return result;
        }
        
        //Удаление тура
        public bool DeleteT (Records records)
        {
            bool result = true;
            Connect();

            try
            {
                SqlCommand cmd = new SqlCommand(
                "DELETE FROM Tour WHERE Id = @ID", Connection);
                cmd.Parameters.Add(new SqlParameter("@ID", records.ID));

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                Disconnect();
            }
            return result;
        }
    }
}
