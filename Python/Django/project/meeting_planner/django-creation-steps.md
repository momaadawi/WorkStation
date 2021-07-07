### Create django app steps
*   create virtual envs >> pipenv shell
*   install django in virtual env. >> pipenv install django
*   create django prject >> django-admin startproject <projectName>
*   test if server run >> python manage.py runserver
*   create web site and add pages >> python manage.py startapp <name>,  add it to INSTALLED_APPS in setting.py

### Setting up a Data Model
*   to list migrations:  python manage.py showmigration
*   look for changes in order to match our database with model class : pyhton manage.py makemigrations
*   to apply all wating migrations :  python manage.py migrate 
*   create database : python manage.py dbshell

### Migration Work Flow
*   IMPORTANT: Make sure your app is in ISTALLED_APP
*   STEP1 : change model code
*   STEP2 : Generate migration script
    *   python manage.py makemigrations
*   STEP3: Run migrations
    *   python manage.py migrate
### create admin UI
* in admin.py : 
``` python
    admin.site.register(entity)
```
* cli: python mange.py createsuperuser

