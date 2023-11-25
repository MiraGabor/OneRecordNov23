import { Question } from './question';

export interface CheckTemplate {
  checks: any[]; // todo
  skeletonIndicator: boolean;
  involvedParties: any[]; // todo
  questions: Question[];
  date: Date;
  name: string;
  templatePurpose: string;
  version: string;
  usedInCheck: any; // todo
}
