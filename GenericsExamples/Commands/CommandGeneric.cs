using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExamples.Commands
{
    public interface IMessage { }
    public interface ICommand : IMessage { }
    public interface IHndler<T> where T: IMessage
    {
        Task Handle(T Message);
    }

    public interface ICommandHandler<T> : IHndler<T> where T: ICommand { }

    public interface ICommandSender
    {
        Task Send<T>(T command, bool defaultCheck = default(bool));
    }

    public class CreateEmployeeCommand : ICommand
    {
        public int Id;
        public string Name;

        public CreateEmployeeCommand(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class CommandHandler : ICommandHandler<CreateEmployeeCommand>
    {
        public Task Handle(CreateEmployeeCommand command)
        {
            Console.WriteLine("CreateEmployeeCommand Is Handled");
            return Task.CompletedTask;
        }
    }

    public class CommandSendHandler : ICommandSender
    {
        public Task Send<CreateEmployeeCommand>(CreateEmployeeCommand command, bool defaultCheck = default(bool))
        {
            var Handler = new CommandHandler();            

            //Handler.Handle();

            return Task.CompletedTask;
        }
    }


}
