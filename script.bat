set /p commmit= "Commit message:  "
git config user.name "massimokris"
git config user.email "maxdo1996@gmail.com"
git add .
git commit -m " %commmit% "
git push
pause
