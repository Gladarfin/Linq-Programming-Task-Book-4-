using PT4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PT4Tasks
{
    public class MyTask: PT
    {
        // ��� ������ ������ ����� �� ��������� ���������� �����
        // � ������ a ���� string[] ����������� ��������:
        //
        //   a = File.ReadAllLines(GetString(), Encoding.Default);
        //
        // ��� ������ ������������������ s ���� IEnumerable<string>
        // � �������������� ��������� ���� ����������� ��������:
        //
        //   File.WriteAllLines(GetString(), s.ToArray(), Encoding.Default);
        //
        // ��� ������� ����� ������ LinqObj �������� ���������
        // �������������� ������ ����������, ������������ � ���������:
        //
        //   Show() � Show(cmt) - ���������� ������ ������������������,
        //     cmt - ��������� �����������;
        //
        //   Show(e => r) � Show(cmt, e => r) - ���������� ������
        //     �������� r, ���������� �� ��������� e ������������������,
        //     cmt - ��������� �����������.

        public static void Solve()
        {
			//LinqObj7�. ���� ����� ����� K � ��� ������ �� �������� ������ - ������.�������� ������������������ �������� �������� � �������� ����� ������ - ������.������ ������� ������������������ �������� ��������� ������������� ����:
            //< ����������������� �������(� �����) > < ��� > < ����� ������ > < ��� ������� >
            //��� ������� ����, � ������� ������ � ����� K ������� �����, ���������� �����, � ������� ����������������� ������� ������� ������� ���� ���������� ��� ������� ����(���� ����� ������� ���������, �� �������� ����� � ���������� �������). �������� � ������ ���� �������� �� ����� ������ � ��������� �������: ���, ����� ������, ����������������� ������� � ���� ������. 
			//������������� �������� �� �������� ������ ����. ���� ������ � ������� � ����� K �����������, �� �������� � �������������� ���� ������ ���� �������.        
            
			Task("LinqObj7");
            int k = GetInt();
            var d = File.ReadAllLines(GetString(), Encoding.Default)
                                                                    .Where(e => int.Parse(e.Split(' ')[3]) == k)            //��������� ������ ������ ������
                                                                    .OrderByDescending(i => int.Parse(i.Split(' ')[1]))     //��������� �� ���� � ��������� �������
                                                                    .ThenByDescending(i => int.Parse(i.Split(' ')[0]))      //����� ��������� �� ����������������� ������� � ��������� �������
                                                                    .ThenBy(i => int.Parse(i.Split(' ')[2]))                //��������� �� ������ � ������������ �������
                                                                    .Select(s => new[] { s.Split(' ')[1],                   //������� ������ ������� ���� { ���, �����, �����������������}
                                                                                         s.Split(' ')[2],                   
                                                                                         s.Split(' ')[0]})
                                                                    .GroupBy(year => year[0],                               //���������� �� ����
                                                                             y => y,
                                                                             (x, y) => y.First())                           //����� ������ ������ �� ������� ����
                                                                    .Select(x => x[0].ToString() + ' ' + x[1].ToString() + ' ' + x[2].ToString()) //��������� ������ � ������
                                                                    .DefaultIfEmpty("��� ������");                          //���� ������ ��� - �� ���������
            File.WriteAllLines(GetString(), d, Encoding.Default);   //����� � ����
        }
    }
}
