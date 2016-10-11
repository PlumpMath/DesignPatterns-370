using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCancelRemote
{
    class RemoteControl
    {
        Command[] onCommands;
        Command[] offCommands;
        Command undoCommand;

        public RemoteControl()
        {
            onCommands = new Command[7];
            offCommands = new Command[7];

            Command noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }

            undoCommand = noCommand;
        }

        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPush(int slot)
        {
            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
        }

        public void OffButtonWasPush(int slot)
        {
            offCommands[slot].Execute();
            undoCommand = offCommands[slot];
        }

        public void UndoButtonWasPush()
        {
            undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder stringBuff = new StringBuilder();
            stringBuff.Append("\n------ Remote Control ------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuff.Append("slot[" + i + "] " + 
                    onCommands[i] + "    " + offCommands[i] + "\n");
            }
            stringBuff.Append("[undo] " + undoCommand + "\n");
            return stringBuff.ToString();
        }
    }
}
