ssh-keygen -t rsa -C "youremail@example.com"
home/.ssh
id_rsa      私匙
id_rsa.pub  公匙

a1.git init <dir>

a2.git add <file1 file2 file3>
a3.git commit -m <message>
a4.git checkout -- <file>    撤销工作区的变更

a5.git status                暂存区变更
a6.git diff <file>           显示变更
a7.git diff HEAD^ <file>     上一个版本对比的变更

a8.git log --pretty=oneline

a9.git reset --hard HEAD^ HEAD^^ HEAD~100  返回之前的版本
b1.git reset HEAD <file> + a4              把暂存区的返回来，HEAD最新版本

b2.git remote add origin url.git           关联远程仓库到本地
b3.git push -u origin master               -u本地分支和远程分支关联
b4.git push origin master                  推送到远程的master分支

b5.git checkout -b dev                     创建并且切换到dev分支
b6.git branch dev                          创建分支
b7.git branch -d dev                       删除分支
b7.git checkout dev                        切换分支
b8.git branch                              查看分支
b9.git merge dev                           将dev分支合并到当前分支
c1.
  
cat <file>       查看文件
git reflog       命令记录



