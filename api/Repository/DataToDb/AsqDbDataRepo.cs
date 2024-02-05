using api.Interfaces.CollectToDb;
using api.Models;
using api.Models.databaseModels.ASQ;

namespace api.Repository.DataToDB
{
    public class AsqDbDataRepo : IAsqDataDb
    {
        public Task<Db_asq2Model> GetLiveDataToDb_asq2()
        {
            throw new NotImplementedException();
        }

        public Task<Db_asq3Model> GetLiveDataToDb_asq3()
        {
            throw new NotImplementedException();
        }

        public Task<Db_asq4Model> GetLiveDataToDb_asq4()
        {
            throw new NotImplementedException();
        }

        public Task<Db_asq5Model> GetLiveDataToDb_asq5()
        {
            throw new NotImplementedException();
        }

        public Task<Db_asq6Model> GetLiveDataToDb_asq6()
        {
            throw new NotImplementedException();
        }

        public Task<(bool success, string errorMessage)> SetIpAddress_asq2(string ipAddress)
        {
            throw new NotImplementedException();
        }

        public Task<(bool success, string errorMessage)> SetIpAddress_asq3(string ipAddress)
        {
            throw new NotImplementedException();
        }

        public Task<(bool success, string errorMessage)> SetIpAddress_asq4(string ipAddress)
        {
            throw new NotImplementedException();
        }

        public Task<(bool success, string errorMessage)> SetIpAddress_asq5(string ipAddress)
        {
            throw new NotImplementedException();
        }

        public Task<(bool success, string errorMessage)> SetIpAddress_asq6(string ipAddress)
        {
            throw new NotImplementedException();
        }
    }
}