import { Question } from './question';

export interface Answer {
  text: string;
  answerValue: any; // todo
  question: Question;
  givenAtLocation: any; // todo
  answerActor: any; // todo
  skeletonIndicator: boolean;
  checks: any[]; // todo
}
