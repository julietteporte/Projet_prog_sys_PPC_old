using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Projet_prog_sys_PPC.Model
{
    class HotelMaster : People
    {
        private int _nbrWelcomedCustomer = 0;

        public int Wallet = 0;
        //Préparation des stratégies
        Customer _objectCustomer = new Customer(new NormalStrategy());
        Customer _objectCustomer2 = new Customer(new SlowStrategy());
        Table _objectTable = new Table();

        private HotelMaster()
        {

        }

        private static HotelMaster _instance = null;
        
        public static HotelMaster Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HotelMaster();
                }
                return _instance;
            }
        }

        public void Welcome(Customer customer)
        {
            _nbrWelcomedCustomer++;
            VerifyReservation(customer);
            AssignTable(customer);
        }

        public void AssignTable(Customer customer)
        {
            if (_objectTable.IsAvailable == true)
            {
                _objectCustomer.Table = new Table();
            }
        }

        public void VerifyReservation(Customer customer)
        {
            if (_objectCustomer.IsReserved == true)
            {   
            }
            else AssignTable(customer);
        }
    }
}
