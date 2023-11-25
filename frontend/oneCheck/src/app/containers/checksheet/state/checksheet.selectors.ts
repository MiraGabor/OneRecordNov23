// import { createSelector, Selector } from '@ngxs/store';
// import { SongDetail } from 'app/models/music.model';
// import { MusicState, MusicStateModel } from './checksheet.state';

// export class MusicStateSelectors {
//     @Selector([MusicState])
//     public static songListItems(state: MusicStateModel) {
//         return state.songs;
//     }

//     @Selector([MusicState])
//     public static albumListItems(state: MusicStateModel) {
//         return state.albums;
//     }

//     @Selector([MusicState])
//     public static allSongs(state: MusicStateModel) {
//         return state.songs;
//     }

//     public static songById(id: string) {
//         return createSelector(
//             [MusicStateSelectors.allSongs],
//             (songs: SongDetail[]) => {
//                 return songs.find((song) => song.id === id);
//             }
//         );
//     }
// }
