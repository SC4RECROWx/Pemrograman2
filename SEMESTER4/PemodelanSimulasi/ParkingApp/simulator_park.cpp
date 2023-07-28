class ParkirSimulator {
private:
    int kapasitas;
    std::vector<std::string> parkir_slots;

public:
    ParkirSimulator(int kapasitas) : kapasitas(kapasitas), parkir_slots(kapasitas) {}

    std::string parkir_mobil(const std::string& mobil) {
        auto it = std::find(parkir_slots.begin(), parkir_slots.end(), "");
        if (it != parkir_slots.end()) {
            int slot = std::distance(parkir_slots.begin(), it);
            parkir_slots[slot] = mobil;
            return "Mobil " + mobil + " berhasil diparkir di slot " + std::to_string(slot + 1);
        } else {
            return "Maaf, parkiran sudah penuh";
        }
    }

    std::string keluarkan_mobil(const std::string& mobil) {
        auto it = std::find(parkir_slots.begin(), parkir_slots.end(), mobil);
        if (it != parkir_slots.end()) {
            int slot = std::distance(parkir_slots.begin(), it);
            parkir_slots[slot] = "";
            return "Mobil " + mobil + " berhasil dikeluarkan dari slot " + std::to_string(slot + 1);
        } else {
            return "Mobil " + mobil + " tidak ditemukan di parkiran";
        }
    }

    std::string status_parkir() {
        std::string status = "Status Parkir:\n";
        for (size_t i = 0; i < parkir_slots.size(); ++i) {
            if (parkir_slots[i].empty()) {
                status += "Slot " + std::to_string(i + 1) + ": Kosong\n";
            } else {
                status += "Slot " + std::to_string(i + 1) + ": Mobil " + parkir_slots[i] + "\n";
            }
        }
        return status;
    }
};