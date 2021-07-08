### pipenv
it's create virtual environement and project,
and install dependencies

##### pipenv commands
pipenv run python <script-name.py> #start new environment
pipenv shell #start new shell in the active environment
exit #deactivate venv

*   pipenv install
    -   it's the same behavior dotnet restore in aspcore install all missed packages in pipfile 
*   pipenv install <packagename> 
    -   install packge and create pipfile for new env
*   pipenv shell
    -   active env
*   pipenv install -r ./requirement.txt
    -   install all packages fom req file 
*   pipenv lock -r
    -   display all packages with verisons  
*   pipenv lock -r > filename.txt
    -   create file contain all packages for non pipenv users in team to be able to install packages
*   pipenv install <packagename> --dev
    -   install packages in develpment env
*   pipenv --python 3.6
    -   overwrite existing virtualenv and recreate it to convenient with new python version
    -   it's better to remove the current env. and recreate it manually
*   pipenv -rm
    -   remove current env.
*   pipenv --venv
    -   get the current env path
*   pipenv check
    -   Check for security vulnerabilities &  fix
*   pipenv graph
    -   list all pakcages and thier dependecies
*   pipenv lock
    - locking dependecies and update pipfile.lock for production
*   pipenv install --ignore-pipfile
    -   install dependencies from pipfile.lock to be ready for production mode


### Poetry
go to [Poetry website](https://python-poetry.org/)

##### start new project
poetry new [<projectname>]

##### install package
poetry add <package-name> 

#####


