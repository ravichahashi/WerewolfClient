using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace WerewolfClient
{
    public class Sound
    {
        // ============================== ประกาศตัวแปรด้วย ============================== 
        private SoundPlayer _audiobackground;
        
        //============================== ใช้ตัวนี้ ============================== 
        private void _deadAudio()
        {
            //============================== ฝากทำ Random ด้วย กูทำไม่ได้ 555 ==============================
            /*  if(มีคนถูกโหวตตาย){
                    Random r = new Random();
                    int rInt = r.Next(1, 2);
                    if (rInt == 1)
                    {
                        _audiobackground = new SoundPlayer("audioDead_1.wav");         
                    }
                    else
                    {
                        _audiobackground = new SoundPlayer("audioDead_2.wav");
                    }
                }else if (ถูกพระสาด){
                    _audiobackground = new SoundPlayer("Watersplashing-sound.wav");
                }else if (ถูกปืนสอย or คุมขังยิง ){
                    _audiobackground = new SoundPlayer("shooting.wav");
                }else if (ถูกฆาตกร หรือ หมาฆ่า){
                    _audiobackground = new SoundPlayer("blood_splat.wav");
                }
                _audiobackground.Play();

            */
        }

        private void _votingaudioCount()
        {
            //============================== หากเหลือ 10 วิสุดท้าย ==============================
            /*if(time <= 10){
                _audiobackground = new SoundPlayer("Voting_time.wav");
                _audiobackground.Play();
                }
            */
        }

        private void _bgaudioLogin()
        {
            _audiobackground = new SoundPlayer("game_backtrack.wav");
            _audiobackground.Play();
        }

        private void _bgaudioNight()
        {
            _audiobackground = new SoundPlayer("mix_night.wav");
            _votingaudioCount();
            _deadAudio();

        }

        private void _bgaudioSunshine()
        {
            _audiobackground = new SoundPlayer("mix_sunshine.wav");
            _votingaudioCount();
            _deadAudio();
        }

        private void _checkWinner()
        {
            /*
            if(แพ้){
                _audiobackground = new SoundPlayer("lost_sound.wav");
            }else{
                    _audiobackground = new SoundPlayer("winner.wav");
            }
            */
        }
        
        
    }

}
