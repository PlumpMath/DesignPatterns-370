using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusCancelRemote
{
    class RemoteControl
    {
        Command[] onCommands;
        Command[] offCommands;
        Stack<Command> undoCommands;

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

            undoCommands = new Stack<Command>();
        }

        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPush(int slot)
        {
            onCommands[slot].Execute();
            undoCommands.Push(onCommands[slot]);
        }

        public void OffButtonWasPush(int slot)
        {
            offCommands[slot].Execute();
            undoCommands.Push(offCommands[slot]);
        }

        public void UndoButtonWasPush()
        {
            try
            {
                Command undoCommand = undoCommands.Pop();
                undoCommand.Undo();
            }
            catch (Exception)
            {

                Console.WriteLine("");
            }
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
            try
            {
                stringBuff.Append("[undo] " + undoCommands.Peek() + "\n");
            }
            catch(Exception)
            {
                stringBuff.Append("[undo] no command\n");
            }
            return stringBuff.ToString();
        }
    }
}
