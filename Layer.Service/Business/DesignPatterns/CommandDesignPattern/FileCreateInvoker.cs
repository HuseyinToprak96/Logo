using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Service.Business.DesignPatterns.CommandDesignPattern
{
    public class FileCreateInvoker
    {
        private ITableActionCommand _tableActionCommand;
        private List<ITableActionCommand> _tableActionCommands=new();
        public void SetCommand(ITableActionCommand tableActionCommand)
        {
            _tableActionCommand = tableActionCommand;
        }
        public void AddCommand(ITableActionCommand tableActionCommand)
        {
            _tableActionCommands.Add(tableActionCommand);
        }

        public IActionResult CreateFile()
        {
            return _tableActionCommand.Execute();
        }
        public List<IActionResult> CreateFiles( string fileName, HttpContext context)
        {
            return _tableActionCommands.Select(x => x.Execute()).ToList();
        }
    }
}