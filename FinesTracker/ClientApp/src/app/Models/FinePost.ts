import {User} from './User';
import {Fine} from './Fine';
import {Vote} from './Vote';

export class FinePost {
  public finePostId!: number;
  public fineId!: number;
  public finerId!: number;
  public fineeId!: number;

  public fine!: Fine;
  public finer!: User;
  public finee!: User;

  public votes!: Vote[];
}
