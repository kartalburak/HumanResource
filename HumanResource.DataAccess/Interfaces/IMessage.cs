using HumanResource.DataAccess.Core;
using System.Collections.Generic;

namespace HumanResource.DataAccess.Interfaces
{
    public interface IMessage
    {
        IEnumerable<Message> GetAll();

        Message GetById(int id);

        bool Add(Message message);

        bool Update(Message message);

        bool Delete(Message message);

        bool Delete(int id);

    }
}
