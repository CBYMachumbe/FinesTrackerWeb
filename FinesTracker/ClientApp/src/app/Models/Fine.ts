export class Fine {
  public fineId!: number;
  public fineTitle!: string;
  public fineText!: string;

  constructor(fineId: number, fineTitle: string, fineText: string) {
    this.fineId = fineId;
    this.fineTitle = fineTitle;
    this.fineText = fineText;
  }

}
