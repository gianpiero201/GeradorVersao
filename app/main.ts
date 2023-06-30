import { GitRepos } from "./config/git-repos";


export class Main {

    async start() {
        GitRepos.GetLocalRepos();
    }
}