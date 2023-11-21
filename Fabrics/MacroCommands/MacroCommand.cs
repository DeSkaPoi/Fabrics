using Fabrics.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrics.MacroCommands
{
    public class MacroCommand : ICommand
    {
        private Queue<ICommand> _commands = new Queue<ICommand>();
        public MacroCommand(Queue<ICommand> commands)
        {
            _commands = commands;
        }

        public void CancelExecute()
        {
        }

        public void Execute()
        {
            try
            {
                foreach (var command in _commands)
                {
                    command.Execute();
                }
            }
            catch (Exception e)
            {
                _commands.Clear();
                throw new Exception(e.Message, e.InnerException);
            }
        }
    }
}
