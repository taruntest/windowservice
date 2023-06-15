#### Pre-requisites:
        msbuild
        vstudio
        .net

Step 1
### Create VM in azure portal 
Step 2
## Deployment Group under pipeline
 1. Create new group
 2. Add resource 
 3. Run the ps script in VM created in step1.
 check in portal if VM is connected 
Step 3
## Windows service code
 1. Dotnet service application
Step 4
## Create build pipeline
 1. Application build, artifact.

Step 5
## Deploy artifact /windows service application
1. Release pipeline
2. Integrate Deployment group, build pipeline 
3. Run the windows service 

### Check for the following service:
    ## Service MessageSenderServiceLocal has been successfully installed

    MessageSenderServiceLocal


