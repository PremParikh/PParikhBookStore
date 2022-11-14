/ Date: 10/24/2022
// Let's get started with using HTTPS
// Individul Account Authentication
// Rozer runtime
// Application project is called 'PParikhBookStore'
//  1:28pm CREATE GitHub repo
// Now confirming the ability to push to the repo
// Around 8:00PM 11/3/2022 starting a project
//  Review the setting of project
// Review the different files with slides
// Check the Views, Shared page
// Debugging the project 
// Check the breakpoint in HomeController file
// See the output
// It's work perfect
// Open a BootWatch.com Arouns 8:15PM 11/3/2022
// Select a Theme Yeati
// Download Bootstrap.css
// Goto wwwroot> replace bootstrap.css
// lib>bootstrap>dist>css
// Goto wwwroot> replace existing site.css file found in the main css folder
// Chnage the file name in Layout.cshtml from bootstrap.min.cs to bootstrap.cs
// Change nav bar-light >> navbar-dark and bg-white>>bg-primary line 13
// Line 23 remove text-dark
// Add additional class footer at the end 
// loginpartial.cshtml >> remove text-dark
// Run the project around 9:10PM 11/3/2022
// Let's take a break.
// Open Jquery UI / Sweet Aleart / Toastr
// Add links of css and JS from blackboard provided files
// Now add a dropdown code
// Now save and check it, Error found
// Add a Additional code provided in class
// Change dropdown to Content Management
//Now it's time to add 3 projects in PParikhBookStore 
//Date: 12/11/2022
//PParikhBooks.DataAccess & PParikhBooks.Models & PParikhBooks.Utility
//on main project PParikhBookStore
//getting an error in migration
//As An unhandled exception occurred while processing the request.
//MissingMethodException: Method not found: 'Boolean Microsoft.EntityFrameworkCore.Migrations.
//IMigrationsModelDiffer.HasDifferences(Microsoft.EntityFrameworkCore.Metadata.IModel, Microsoft.EntityFrameworkCore.Metadata.IModel)'.
//solve it.
//Now 3:10PM
// Copy data folder and paste in .dataaccess folder and delete the original
// Install packages
// Micro.EntityFrameWorkCore.Relational
// Micro.Core.SqlServer
// Delete Migration Folder 
// Identity.EFCore
// Edit PremBookSTore.DaTACcess.Data in ApplicationDbContext.cs
// Add project Reference from Original Bookstore folder
// Add >> Project Ref >> .DataAccess + .Models 
// Click Ok
// Almost 3:15PM 12/11/2022
// rename models folder to ViewModels in dataAccess
// Change PremBookStore.Models to namespace PremBookStore.Models.ViewModels in VieeModel File
// Run a Project
// Getting Some Project
// Solve it using references
// Now Add a SD.cs file in utility Project
// Modify code
// Add a reference ALL 3 in a Bookstore Project
// Now it's time to add Area in customr
// Change the Startup.cs like the one ScaffoldingReadMe.txt
// Area > Customet > Controller folder and delete Data and Models
// Run a Application Now
// Add a new Admin area in Areas
// Add the proper view files and delete the controllers folder
//Update the Github repo
// Now run a code
//Now Move forward on Part-2
//'build' a project and confirm there are no errors
// Review the appsettings.json
//Create the migrations using code-first
//changes database name="PParikhBookStore"
//Save it
//Now open COnsole and add migration
//Changes the default to .DataAccess
//Run it and it's Works
//Review the files for sql
//syntax,statement,primary key was added
//Once migration is complete, the database needed to update
//In the console, Update the database NOW.
//Review the updated database in the Sql
//Check the error, and run it it's almost 4:00PM
//Add a new table to the DB by creating a Category model
//Add a new class file to .Models project and modify
//Add a migration via the PM Console
//The new migration file will be empty bcz 
//hasn't added to teh Application DB Context
//Updated 
//Re-run and add migration and review the changes to the AddCategoryToDb
//getting an error
//resolve it
//Update the Database: & confirm the new categories
//Part 2: Repository :8:00PM 13/11/2022
//Creating Caregory.cs 
//Adding a ApplicationDbContext 
// a generic way of accessing common functionality
//getting a record in the .dataaccess Project.
//Add folder: 'repository' 
//Add IRepository for the interfaces folder inside it.
//Add a new item of type interface to the folder
//Name it: IRepository.cs
// Modify: it can be used on the category class to do akk the CRUD operayion
// Method of CRUD
// GET ITEM FROM THE DB
// LIST OF CATEGORIES
// ADD OBJECT
// REMOVE OBJECT
// implement the class 
// include the using statement
// View the potential fixes 'IMPLEMENT INTERFACE'
// Modify the code to create the constructor and dependency injection(DI)
// Create individual repos for category and all potential models
// CategoryRepository.cs &&&&&&&&& ICategoryRepository.cs file
// Modify CategoryRepository 
// Special NOTE: using statement and the message for formal parameter- review in Repository.cs
// Modify ICategoryRepository interface
// Review and modify the error now in CategoryRepository.cs
// Complete the remaining modifications
// Build and fixing an ERROR 
// it's time to push in GITHUB
// Implement a stored procedure repository and map multiple repositories in a unit OF WORK.
// Add a new INTERFACE
// IRepository > ISP_Call.cs > IDisposable
// Include the methods shown 
// install the NuGet package IN DAPPER
// Implement a NEW CLASS > REPOSITORY
// Add a class SP_Call.cs in REPO folder
// select the appropriate using statement
// Add a connection to the database
// UPDATE IDP_Call interface
// NOW add the wrapper For unit of work
//ADD a new INTERFACE (IUOW) to the IRepository folder
// UPDATE THE CODE
// Inside the UNITOFWORK (ADD A CLASS)
// Modify the Code
// MAKE SURE the public class implements the interface - UNITOFWORK > IUNITOFWORK
// Accessible by the project, register it > Startup.cs in ConfigureServices 
// Build and correct any ERRORS, push commits to GITHUB
// PART_2 : Category CRUD
// Addition of UnitOfWork in Startup.cs
//Accessible with DI by any controller
// Close all opend tab
// ADD a new MVC Controller - inside Areas>Admin
// Category.cs : Name
// Modify the code to use the IUNITOFWORKS from
// .DataAccess project and IREPOSITORY Folder
// Always used using statement
// Add a new Folder in AREAS > VIEW With the name of Controller
// ADD a new INDEX View to the folder
// Modify with the generic HTML Code From the Category Index View.txt
// WHich is Available in blackboard
// SAVE AND RUN
// _Layout.cshtml > 'Category' Link to content Management drop_down
// Review the changes to the navigation
// Push to GITHUB
// Modify the INDEX.CSHTML to ADD the icons in the Category section from Font Awesome and Confirm
// Delete it and add the JS file from blackboard into the WWWROOT > JS folder
// NOTE : 'div' is now in the return portion of category.js
// ADD the @section call to the CATEGORY.JS Script 
// run the project
// Time to Apply the code to active 'EDIT' & 'DELETE' button
// 'Create New Category' using the Upsert action
// Add the IAction result to the Controller
// Add a View 
// COPY and ADD the html > Category Upsert View.txt
// Create a partial View for the EDIT > BACK
// general Views > Shared folder
// ADD the partial View for _CreateAndBackToListButton 
// cshtml and add the asp-action
// create another partial view for _EDITANDBACKTOLISTBUTTON 
// Note the code addition of @model rozer statement
// Modify the Upsert.cshtml 
// Add the asp-action to the INDEX.CSHTML page and run the application
// Navigate to Category > CREATE NEW CATEGORY
// Modify Upsert.cshtml 
// Now title uses the #title variable and refresh the APP.
// ADD @section call to script to validate input on the client-side and test.
// NOW create an Upsert POST action in the CategoryController.cs
// Save method is not available.
// NOW ADD the void save() method to the IUNITOFWORK Interface
// remove the _db.SaveChanges() method in the CategoryRepository.cs
// Move the _unitOfWork.save() method the return RedirectToaction method
// Check for ERROR and test whether the application can updATE
// Create a category
// Add the API call for HTTPDelete in the Categorycontroller.cs
// Implement the HTTPDelete with a delete method in category.js 
// to ADD functionality to the application and call the API
// Add the delete in category.js WITH including
// ADD the delete URL function code
// uses the SWEET_ALERT for success and ERROR messsage
// Uses Toastr for NOTIFICATION
// After this has been added, save, check for ERROR and RUN & test the app
// UPDATE README 
// It's time to push on GITHUB
// that's end of part-2
//Getting Error and it's solved
//it's almost 1:32AM 14/11/2022
//END.......

