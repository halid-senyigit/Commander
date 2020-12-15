using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return new List<Command>{
                new Command{
                    Id = 0,
                    HowTo = "Boil an egg",
                    Line = "Boil water",
                    Platform = "Kettle & Pen"
                }, 
                new Command{
                    Id = 1,
                    HowTo = "Boil an egg 1",
                    Line = "Boil water 1",
                    Platform = "Kettle & Pen 1"
                }, 
                new Command{
                    Id = 2,
                    HowTo = "Boil an egg 2",
                    Line = "Boil water 2",
                    Platform = "Kettle & Pen 2"
                }
            };
        }

        public Command GetCommandById(int id)
        {
            return new Command{
                Id = 0,
                HowTo = "Boil an egg",
                Line = "Boil water",
                Platform = "Kettle & Pen"
            };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}