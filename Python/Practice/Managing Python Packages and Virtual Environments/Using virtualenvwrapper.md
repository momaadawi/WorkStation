### Virtualenv Wrapper
- a user friendly wapper around virtualenv
- eady creattion and activation
- bind project to virtural envs
- greate with large number of projects 

##### install virtualenv wrapper
``` python
pip install virtualenvwrapper-win
```

##### start workon
type workon : if it doesnt show anything
[Environment]::SetEnvironmentVariable("WORKON_HOME", "C:\Venv", "User")
[Environment]::SetEnvironmentVariable("PROJECT_HOME", "C:\Project", "User")
try: cmd /k workon

##### VirtualWarpper commands:
**#create a project and virtualenv and bind them**
mkproject <"new-project">
mkproject -p python3 <"new-project">

**#bind an existing project to a virtualenv**
setvirtualenvproject

**#Create a virtualenv**
mkvirtualenv
**#remove a virtualenv**
rmvirtualenv
**#create temporary  virtualenv**
mktmpenv

