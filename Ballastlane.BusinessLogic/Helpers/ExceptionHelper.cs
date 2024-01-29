using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballastlane.BusinessLogic.Helpers
{
    public class ExceptionHelper
    {
        public static ArgumentNullException GetInvalidInputsException(string CustomMessage = null)
        {
            return new ArgumentNullException(String.IsNullOrEmpty(CustomMessage) ? CustomMessage : "Invalid entries");
        }

        public static Exception GetEntityAlreadyExistsException(string? CustomMessage = null)
        {
            return new Exception(String.IsNullOrEmpty(CustomMessage) ? CustomMessage : "Entity already exists");
        }

        public static Exception GetEntityNotFoundException(string? CustomMessage = null)
        {
            return new Exception(String.IsNullOrEmpty(CustomMessage) ? CustomMessage : "Entity not found");
        }
    }
}

