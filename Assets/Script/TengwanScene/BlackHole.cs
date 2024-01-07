using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    public class Position
    {
        public float radius = 0f, angle = 0f;
        public Position(float r, float a)
        {
            radius = r;                         // �뾶
            angle = a;                          // �Ƕ�
        }
    }

    private ParticleSystem parSys;              // ����ϵͳ  
    private ParticleSystem.Particle[] parArr;   // ��������  
    private Position[] parPos;                  // ����λ������  

    public int num = 10000;         // ��������  
    public float size = 0.03f;      // ���Ӵ�С  
    public float r = 5f, R = 10f;   // �ڰ뾶����뾶  
    public float speed;

    void Start()
    {
        parArr = new ParticleSystem.Particle[num];
        parPos = new Position[num];

        parSys = this.GetComponent<ParticleSystem>();
        var main = parSys.main;
        main.startSpeed = 0;
        main.startSize = size;
        main.loop = false;
        main.maxParticles = num;
        parSys.Emit(num);
        parSys.GetParticles(parArr);

        SetRandom();
    }

    void SetRandom()
    {
        for (int i = 0; i < num; i++)
        {
            float min = Random.Range(1f, (r + R) / (2 * r)) * r;
            float max = Random.Range((r + R) / (2 * R), 1.2f) * R;
            float radius = Random.Range(min, max);
            // ��������뾶����Ҫ�����ڻ��м�

            float angle = Random.Range(0f, 360f);
            float radian = angle * 180 / Mathf.PI;
            // ��������Ƕ�

            parPos[i] = new Position(radius, angle);
            parArr[i].position =
                new Vector3(parPos[i].radius * Mathf.Cos(radian),
                            0f,
                            parPos[i].radius * Mathf.Sin(radian));
            // �趨���ӵ����λ��
        }
        parSys.SetParticles(parArr, parArr.Length);
        // ���������ɵ�������ӷ�������ϵͳ��
    }

    void Update()
    {
        // ����ÿ������λ�úͽǶ�
        for (int i = 0; i < num; i++)
        {
            // ˳ʱ����ת  
            parPos[i].angle = (parPos[i].angle - Random.Range(0.5f, 3f)) % 360f;
            float radian = parPos[i].angle / 180 * Mathf.PI;
            parArr[i].position = new Vector3(parPos[i].radius * Mathf.Cos(radian),
                                            0f,
                                            parPos[i].radius * Mathf.Sin(radian));
        }
        parSys.SetParticles(parArr, parArr.Length);
    }
}
