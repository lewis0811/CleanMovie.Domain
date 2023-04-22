## CLEAN ARCHITECTURE DESIGN

# Infrastructure:
- Class:
	+ DbContext
	+ MovieRepository
- Framework:
	+ EFCore
	+ EFCore.Design
	+ EFCore.SqlServer

# Domain
- Model class:
	+ Category
	+ Movie

# Application
- Interface:
	+ IMovieRepository
	+ ICategoryService
	+ IMovieService
- Service:
	+ CategoryService
	+ MovieService

# API test
- Migrations
	+ AddCategoryMovie
- Controllers
	+ CategoryController
	+ MovieController

# API Demo
![Get Category](/Pictures/GetCategory.png?raw=true)
![Get Movie](/Pictures/GetMovie.png?raw=true)
![Add Movie](/Pictures/AddMovie.png?raw=true)
