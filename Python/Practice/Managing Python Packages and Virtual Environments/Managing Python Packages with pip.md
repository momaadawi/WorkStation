### Managing Python Packages with pip

##### check pip version
pip -V
*   if it dosent work set enviroment variables of the system with path and script

##### install package
pip install <pacakge name>

##### list all package on the system
*   pip list 
*   pip list -o 
>
    -o : list out of date packages
> 
*   pip show <package name> /show details about package

##### hint
>
    when you install package its located in sys
    import.sys
    in sys.paths : will get directories that store modules, the interpters search in thus directoris for modules which you import
*   
>
###### better way to call pip explicty
>
    python<version> -m pip install <package name>
>