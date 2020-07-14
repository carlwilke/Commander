using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commander.Model;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command {Id = 0, HowTo = "Boil a banana", Line = "Boil Oil", Platform = "Stove & Pan"},
                new Command {Id = 0, HowTo = "Cut bread", Line = "Get a knife", Platform = "Knife & chopping board"},
                new Command {Id = 0, HowTo = "Make Coffee", Line = "Boil Water", Platform = "Bialetti and coffee"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil a banana", Line = "Boil Oil", Platform = "Stove & Pan" };
        }

        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
