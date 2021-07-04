### Setting up Your Project with Virtual Environments

##### Virtual Enviroments
>
*   is isolated context for installing packages
*   always work inside a virual envioment
    *   no globals installs any more
    *   create a virtula env. for every project
*   isolated project dependecies
    *   no more confilcts with other projects
>

##### create a virtual envoiroment
``` python
python -m pip install virtualenv
# virtualenv --version
```
*   create enviroment
*   virtualenv <name>
*   virtualenv -p python3<choose interpter> projectname 
*   activate env: <envname>\Scripts\activate.ps1, <envname>\Scripts\activate.bat (windows old virsion),  . <envname>\bin\activate (mac)
*   will create project with
    *   #lib folder
    *   #scripts : its as bin folder

###### virtual env. package mangement
**#to get list of packages with versions**
[read the diffrence between list and freeze](https://note.nkmk.me/en/python-pip-list-freeze/)
*   python -m pip freeze 
#create configuration file(export for other envs.) with contain package names and version
*   python -m pip freeze > requirements

>
-   to import env package requirements from other env
python -m pip install -r <name>
>
**#specifying Version**
>
docopt == 0.6.1 #must be version 0.6.1
keyring >= 4.1.1 #minmum version 4.1.1
coverage != 3.5 #anything except version 3.5
>

**#Versions and pip**
```python
python -m pip install flask==0.9 #must be 0.9
python -m pip install 'Diango<2.0' #any version below 2.0
```
*#Upgrade to last version*
```python
python -m pip install -U flask #-U is Capital
```

**install package from directort**
``` python
python -m pip install -e <packagename>
```
