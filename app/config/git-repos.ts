import { promises as fs } from 'fs';
import { Repository } from '../models/repository';

export class GitRepos {
    
    static repos: Repository[];

    static GetLocalRepos() {
        const rootpath = process.cwd().split('/')[0];
        console.log(rootpath);
        //const folders = fs.readdir(rootpath)
    }

}