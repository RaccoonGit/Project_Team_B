using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ScriptableObject
{
    [SerializeField]
    public int _id; // �ε���
    [SerializeField]
    public string _itemName; // ������ �̸�
    [SerializeField]
    public Sprite _itemImage; // ������ ��ǥ �̹���
    [SerializeField]
    public GameObject _itemPrefab; // �ٴڿ� ������ �� ������ ������
    [SerializeField]
    public string _itemTooltip; // ������ ����
}