using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneIncludeManyCommands
{
    class MacroCommand : Command
    {
        private Command[] commands;

        public MacroCommand(params Command[] commands)
        {
            this.commands = commands;
        }
        public void Execute()
        {
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i].Execute();
            }
        }

        public void Undo()
        {
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i].Undo();
            }
        }
    }
}
