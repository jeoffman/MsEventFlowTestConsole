git filter-branch --commit-filter '
        if [ "$GIT_AUTHOR_EMAIL" = "jeoffman@hines.me" ];
        then
                GIT_AUTHOR_NAME="jeoffman";
                GIT_AUTHOR_EMAIL="jeoffman@gmail.com";
                git commit-tree "$@";
        else
                git commit-tree "$@";
        fi' HEAD