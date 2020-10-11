using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Dao;
using Entidades_POJO;


namespace DataAccess.Crud
{
    public class CreditoCrudFactory
    {
       CreditoMapper mapper;

        public CreditoCrudFactory() : base()
        {
            mapper = new CreditoeMapper();
            dao = SqlDao.GetInstance();
        }

        public override void Create(BaseEntity entity)
        {
            var customer = (Credito)entity;
            var sqlOperation = mapper.GetCreateStatement(customer);
            dao.ExecuteProcedure(sqlOperation);
        }



        public override T Retrieve<T>(BaseEntity entity)
        {
            var sqlOperation = mapper.GetRetriveStatement(entity);
            var lstResult = dao.ExecuteQueryProcedure(sqlOperation);
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                dic = lstResult[0];
                var objs = mapper.BuildObject(dic);
                return (T)Convert.ChangeType(objs, typeof(T));
            }

            return default(T);
        }

        public override List<T> RetrieveAll<T>()
        {
            var lstCreditos = new List<T>();

            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetriveAllStatement());
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                var objs = mapper.BuildObjects(lstResult);
                foreach (var c in objs)
                {
                    lstCreditos.Add((T)Convert.ChangeType(c, typeof(T)));
                }
            }

            return lstCreditos;
        }

        public override void Update(BaseEntity entity)
        {
            var cliente = (Credito)entity;
            dao.ExecuteProcedure(mapper.GetUpdateStatement(cliente));
        }

        public override void Delete(BaseEntity entity)
        {
            var cliente = (Credito)entity;
            dao.ExecuteProcedure(mapper.GetDeleteStatement(cliente));
        }
    }
}