using System.Runtime.InteropServices;

namespace ManagedBridge;
public class BLE {
    public static class Safe {
        public static void sayHello() {
            try {
                BLE.sayHello();
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }

    [DllImport("BleWinrtDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
    private static extern void sayHello();
}
