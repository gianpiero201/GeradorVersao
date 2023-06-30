import { SimpleGit, simpleGit } from "simple-git";
import { GitRepos } from "../config/git-repos";

export class GitService {

    git: SimpleGit = simpleGit()

    constructor() { }

    gitClone(project: string) {
        if (GitRepos.repos.some(r => r.Name === project)) {
            throw new Error("Projeto já existe");
        }
        return this.git.clone(project,);
    }
}