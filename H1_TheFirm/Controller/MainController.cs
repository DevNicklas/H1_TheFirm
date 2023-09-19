using H1_TheFirm.Model;
using H1_TheFirm.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_TheFirm.Controller
{
    /// <summary>
    /// Class <see cref="MainController"/> controls the whole program
    /// </summary>
    internal class MainController
    {
        /// <summary>
        /// Starts the controller
        /// </summary>
        public void Start()
        {
            #region Employees
            Employee employee = new Employee("Peter", "Hystrup", "10021998-2437");
            Sweeper sweeper = new Sweeper("Loke", "Karlstrup", "04042005-2859");
            Manager manager = new Manager("Ulrik", "Yddrasil", "03022000-3459", "65656565");
            ProjectManager projectManager = new ProjectManager("Rico", "Juvelsen", "08082003", "23232323", "ricojuvelsen@outlook.com");
            #endregion

            #region Gui Instances
            EmployeeGUI employeeGUI = new EmployeeGUI();
            SweeperGUI sweeperGUI = new SweeperGUI();
            ManagerGUI managerGUI = new ManagerGUI();
            ProjectManagerGUI projectManagerGUI = new ProjectManagerGUI();
            #endregion

            employeeGUI.ShowEmployee(employee);

            sweeperGUI.ShowSweeper(sweeper);

            managerGUI.ShowManager(manager);

            projectManagerGUI.ShowProjectManager(projectManager);

            // Waits for a user to press any key, for closing the program
            UserInput userInput = new UserInput();
            userInput.GetPressedKey();
        }
    }
}
