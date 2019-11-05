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


cat <file>       查看文件
git reflog       命令记录


